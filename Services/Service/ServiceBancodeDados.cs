using System;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ServiceBancodeDados: IServiceBancoDeDados
    {

        private int TentaTivasCriarBanco = 0;
 



        private readonly IRepositoryVerificacaoBancoDedados _repositorio;

        public ServiceBancodeDados(IRepositoryVerificacaoBancoDedados repositorio)
        {
            _repositorio = repositorio;
        }
       public async Task RealizarVerificacaoBancoDados()
        {
            await Task.Run(() => {
                                    if (_repositorio.ValidarConexaoComAInstancia())
                                    {
                                         if (_repositorio.validarExistenciaBancodeDadosConfigurado())
                                             return;

                                            try
                                            {
                                                _repositorio.CriarBaseDeDadosDefaut();
                                                
                                            }
                                            catch (Exception ex)
                                            {
                                                    throw ex;
                                            }
                                        
                                    }
                                    else
                                    {
                                        throw new Exception("Nao possivel Realizar Conexao com a Instancia!");
                                    }
                                });


           
        }

        private async Task GerenciarTenativa()
        {
            this.TentaTivasCriarBanco++;

            if (TentaTivasCriarBanco >= 3)
                throw new Exception("Excedeu as tentantivas de Criar o banco de dados");



            if (!_repositorio.validarExistenciaBancodeDadosConfigurado())
               await  RealizarVerificacaoBancoDados();

            else
                return;

        }
    }
}
