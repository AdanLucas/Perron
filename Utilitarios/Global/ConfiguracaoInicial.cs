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
    public string StringConexaoMaster
    {
        get
        {
            if (Configuracao.ConexaoBancoDados.LocalDb)
                return stringConexaoLocalDbMaster;

            else 
                return stringConexaoMaster;
        }
    }
    public string StringConexaoDados
    {
        get
        {
            if (Configuracao.ConexaoBancoDados.LocalDb)
                return this.stringConexaoLocalDb;

            else
                return this.stringConexaoDados;
        }
    }

    private string stringConexaoMaster
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
    private string stringConexaoDados
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
    private string stringConexaoLocalDb
    {
        get
        {
            return
            $@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog={instance.Configuracao.ConexaoBancoDados.Banco};Integrated Security=True;";
        }
    }
    private string stringConexaoLocalDbMaster
    {
        get
        {
            return
            $@"Data Source={Configuracao.ConexaoBancoDados.Instancia};Initial Catalog=master;Integrated Security=True;";
        }
    }


    private static ConfiguracaoInicial instance;
    private ConfiguracaoInicial()
    {
        GerenciandoXmlConfiguracao xmlConfiguracao = new GerenciandoXmlConfiguracao();
        XmlDocument xml = xmlConfiguracao.GetXMlConfiguracao();

        Configuracao = SerializarObjeto.DeserializarXml(xml);
    }


    public void Iniciar() { }

    




}

