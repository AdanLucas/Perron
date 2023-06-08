using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Utilitarios.ArquivoConfiguracao;
using Utilitarios.Xml;



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

