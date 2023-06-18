using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Service
{
    public class ServicePreco : IServiceCadastroPreco
    {
        private readonly IRepositoryPreco _repoPreco;
        private readonly IRepositoryTamanho _repoTamanho;
        private readonly IRepositoryClasse _repoClasse;

        public ServicePreco(IRepositoryPreco preco
                                ,IRepositoryTamanho repoTamanho
                                    ,IRepositoryClasse repoClasse)
        {
            _repoPreco = preco;
            _repoTamanho = repoTamanho;
            _repoClasse = repoClasse;
        }
        public List<ClasseModel> GetClasses()
        {
            var ListaClasse = _repoClasse.GetLista(EStatusCadastro.Ativo);

            if (ListaClasse.Count == 0)
                throw new Exception("Não Existe Classes Cadastrados");

            return ListaClasse;
        }
        public List<PrecoModel> GetPrecoPorClasse(int IdClasse)
        {
            var ListaPreco = _repoPreco.GetListaPrecoPorClasse(IdClasse);
            if (ListaPreco.Count == 0)
                throw new Exception("Nao existe Precos cadastrados para essa Classe");


            return ListaPreco;
        }
        public List<TamanhoModel> GetTamanhos()
        {
           var listaTamanho = _repoTamanho.GetListaTamanho(EStatusCadastro.Ativo);

            if (listaTamanho.Count == 0) throw new Exception("Nao Existem cadastro de Tamanhos Ativos");

            return listaTamanho;

        }
        public void SalvarListaPrecos(List<PrecoModel> ListaPreco)
        {
            try
            {
                _repoPreco.SalvarListaPreco(ListaPreco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
