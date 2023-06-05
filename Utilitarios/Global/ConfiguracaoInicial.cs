using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Utilitarios.ArquivoConfiguracao;
using Utilitarios.Xml;



public class ConfiguracaoInicial
{
    public static ConfiguracaoInicial Instancia
    {
        get
        {
            if (instance == null)
                instance = new ConfiguracaoInicial();


            return instance;
        }

    }

    public ArqConfiguracao Configuracao { get; set; }
    private static ConfiguracaoInicial instance;
    
    public string StringConexaoDados
    {
        get
        {
            return
            $@"Data Source={instance.Configuracao.ConexaoBancoDados.Instancia};
            Initial Catalog={instance.Configuracao.ConexaoBancoDados.Banco};
            User Id={instance.Configuracao.ConexaoBancoDados.Usuario};
            Password={instance.Configuracao.ConexaoBancoDados.Senha};";
        }
    }
    public string StringConexaoMaster
    {
        get
        {
            return
            $@"Data Source={instance.Configuracao.ConexaoBancoDados.Instancia};
            Initial Catalog=master;
            User Id={instance.Configuracao.ConexaoBancoDados.Usuario};
            Password={instance.Configuracao.ConexaoBancoDados.Senha};";
        }
    }



    private ConfiguracaoInicial()
    {
        GerenciandoXmlConfiguracao xmlConfiguracao = new GerenciandoXmlConfiguracao();
        XmlDocument xml = xmlConfiguracao.GetXMlConfiguracao();

        Configuracao = SerializarObjeto.DeserializarXml(xml);
    }


    public void Iniciar() { }

    




}

