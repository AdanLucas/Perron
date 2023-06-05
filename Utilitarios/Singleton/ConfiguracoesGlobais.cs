using System;
using System.Collections.Generic;
using System.Text;
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

    public ArqConfiguracao ConfiguracaoInicial { get; set; }
    private static ConfiguracoesGlobais instance;

    public string StringConexaoDados
    {
        get
        {
            return
            $@"Data Source={instance.ConfiguracaoInicial.ConexaoBancoDados.Instancia};
            Initial Catalog={instance.ConfiguracaoInicial.ConexaoBancoDados.Banco};
            User Id={instance.ConfiguracaoInicial.ConexaoBancoDados.Usuario};
            Password={instance.ConfiguracaoInicial.ConexaoBancoDados.Senha};";
        }
    }
    public string StringConexaoMaster
    {
        get
        {
            return
            $@"Data Source={instance.ConfiguracaoInicial.ConexaoBancoDados.Instancia};
            Initial Catalog=master;
            User Id={instance.ConfiguracaoInicial.ConexaoBancoDados.Usuario};
            Password={instance.ConfiguracaoInicial.ConexaoBancoDados.Senha};";
        }
    }



    private ConfiguracoesGlobais()
    {
        GerenciandoXmlConfiguracao xmlConfiguracao = new GerenciandoXmlConfiguracao();
        XmlDocument xml = xmlConfiguracao.GetXMlConfiguracao();

        ConfiguracaoInicial = SerializarObjeto.DeserializarXml(xml);
    }


    public void Iniciar() {}




}

