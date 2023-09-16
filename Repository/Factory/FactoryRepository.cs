using Model.Emumerator;
using Repository.Repository;
using System;


public static class FactoryRepository
{
    public static IRepositorySabor Sabor()
    {
        return new RepositorySabor();
    }
    public static IRepositoryTamanho Tamanho()
    {
        return new RepositoryTamanho();
    }
    public static IRepositoryEngrediente Engrediente()
    {
        return new RepositoryEngrediente();
    }
    public static IRepositoryDadosEngredienteSabor DadosEngredienteSabor()
    {
        return null;
    }
    public static IRepositoryClasse Classe()
    {
        return new RepositoryClasse();

    }
    public static IRepositoryVerificacaoBancoDedados VerificacaoBancodeDados()
    {
        return new RepositoryBancoDeDados();
    }
    public static IRepositoryPreco Preco()
    {
        return new RepositoryCadastroPreco();
    }
    public static IReposotiryTipoPessoa TipoPessoa(ETipoPessoa tipo)
    {

        var repo = tipo.GetDadosRepository();
        var _type = Type.GetType(repo);

        if (_type == null)
            throw new Exception("Classe nao Existe");

        return (IReposotiryTipoPessoa)Activator.CreateInstance(_type);
    }

}

