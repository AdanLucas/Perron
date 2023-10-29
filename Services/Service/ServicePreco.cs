using System;
using System.Collections.Generic;


namespace Services.Service
{
    public class ServicePreco : IServiceCadastroPreco
    {
        private readonly IRepositoryPreco _repoPreco;
        private readonly IRepositoryTamanho _repoTamanho;
        private readonly IRepositoryClasse _repoClasse;

        public ServicePreco(IRepositoryPreco preco
                                , IRepositoryTamanho repoTamanho
                                    , IRepositoryClasse repoClasse)
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
        public void SalvarListaPrecos(params object[] parametro)
        {
            try
            {
                _repoPreco.SalvarListaPreco(parametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoverTodosVinculoDeClasseComPrecos(Int64? IdClasse)
        {
            try
            {
                _repoPreco.RemoverTodosVinculoClassePreco(IdClasse);
    }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoverVinculoPrecoComClasse(Int64? IdClasse,Int64? IdPreco)
        {
            try
            {
                _repoPreco.RemoverVinculoPrecoClasse(IdClasse, IdPreco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
