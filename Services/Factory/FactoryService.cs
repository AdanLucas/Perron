using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class FactoryService
{
    public static IServiceEngrediente Engrediente()
    {
        var repo = FactoryRepository.Engrediente();

        return new ServiceEngrediente(repo);
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
}

