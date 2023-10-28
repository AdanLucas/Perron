using Model.Emumerator;
using Model.Interface.Repository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public static class FactoryRepository
{
    public static IRepositoryProduto Produto()
    {
        return new RepositoryProduto();
    }
    public static IRepositoryTamanho Tamanho()
    {
        return new RepositoryTamanho();
    }
    public static IRepositoryMercadoria Mercadoria()
    {
        return new RepositoryMercadoria();
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
    public static IRepositoryBuscaDinamico BuscaDinamico(Type tipo)
    {
        List<Type> listaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IRepositoryBuscaDinamico))).ToList();

        foreach (var t in listaClasses)
        {
            IRepositoryBuscaDinamico repo = (IRepositoryBuscaDinamico)Activator.CreateInstance(t);

            if(repo.TipoRepositorio.Equals(tipo))
                                        return repo;

        }
        return null;

    }


}

