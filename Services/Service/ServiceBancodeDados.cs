using Model.Interface.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ServiceBancodeDados: IServiceBancoDeDados
    {


 



        private readonly IRepositoryVerificacaoBancoDedados _repositorio;

        public ServiceBancodeDados(IRepositoryVerificacaoBancoDedados repositorio)
        {
            _repositorio = repositorio;
        }



       public async Task<bool>RealizarVerificacaoBancoDados()
        {
            bool ret = false;
            await 
                Task.Run(() =>
                                {
                                    if (_repositorio.ValidarConexaoComAInstancia())
                                    {
                                        if (!_repositorio.validarExistenciaBancodeDadosConfigurado())
                                        {
                                            try
                                            {
                                                _repositorio.CriarBaseDeDadosDefaut();


                                                ret = _repositorio.validarExistenciaBancodeDadosConfigurado();
                                            }
                                            catch (Exception ex)
                                            {
                                                throw ex;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Nao possivel Realizar Conexao com a Instancia!");
                                    }
                                                                                                                             });


            return ret;
        }
    }
}
