using System;
using System.Threading.Tasks;



public class ConfiguracoesGlobais
{
    public static ConfiguracoesGlobais Instancia
    {
        get
        {
            if (instance == null)
                instance = new ConfiguracoesGlobais();


            return instance;
        }

    }
    private static ConfiguracoesGlobais instance;
    private IServiceBancoDeDados _serviceBancodedados;

    private ConfiguracoesGlobais()
    {
        _serviceBancodedados = FactoryService.BancoDados();
    }
    public async Task Iniciar() 
    {
        try
        {
            ConfiguracaoInicial.Instancia.Iniciar();
            await _serviceBancodedados.RealizarVerificacaoBancoDados();

        }
        catch (Exception ex)
        {

            throw ex;
        }



    
    }
}

