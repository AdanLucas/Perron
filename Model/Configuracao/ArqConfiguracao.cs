using Model.Configuracao;
using System.Xml.Serialization;


public class ArqConfiguracao
{
    [XmlElement("API")]
    public ConfiguracaoAPI API { get; set; }


    [XmlElement("ConexaoBanco")]
    public ConfiguracaoConexaoBancoDados ConexaoBancoDados { get; set; }

    [XmlElement("ConfiguracaoGeral")]
    public ConfiguracoesGerais ConfiguracaoGeral { get; set; }



}

