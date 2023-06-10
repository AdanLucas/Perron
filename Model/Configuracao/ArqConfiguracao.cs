using System.Runtime.CompilerServices;
using System.Xml.Serialization;


public class ArqConfiguracao
{
    [XmlElement("API")]
    public ConfiguracaoAPI API { get; set; }


    [XmlElement("ConexaoBanco")]
    public ConfiguracaoConexaoBancoDados ConexaoBancoDados { get; set; }

}

