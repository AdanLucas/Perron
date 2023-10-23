using Model.Emumerator;
using Services.Service;


public static class FactoryService
{

    public static IServiceMercadoria Mercadoria()
    {
        var repo = FactoryRepository.Mercadoria();

        return new ServiceMercadoria(repo);
    }
    public static IServiceSabor Sabor()
    {
        var repo = FactoryRepository.Sabor();
        return new ServiceSabor(repo);

    }
    public static IServiceClasse Classe()
    {
        var reposotiry = FactoryRepository.Classe();

        return new ServiceClasse(reposotiry);
    }
    public static IServiceTamanho Tamanho()
    {
        var repo = FactoryRepository.Tamanho();

        return new ServiceTamanho(repo);
    }
    public static IServiceBancoDeDados BancoDados()
    {
        var repo = FactoryRepository.VerificacaoBancodeDados();
        return new ServiceBancodeDados(repo);
    }
    public static IServiceCadastroPreco CadastroPreco()
    {
        var _repoPreco = FactoryRepository.Preco();
        var _repoTamanho = FactoryRepository.Tamanho();
        var _repoClasse = FactoryRepository.Classe();

        return new ServicePreco(_repoPreco, _repoTamanho, _repoClasse);
    }
    public static IServiceTipoPessoa CadastroTipoPessoa(ETipoPessoa tipo)
    {
        var repo = FactoryRepository.TipoPessoa(tipo);
        return new ServiceTipoPessoa(repo);
    }
}

