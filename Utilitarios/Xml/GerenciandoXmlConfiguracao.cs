using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Utilitarios.Xml
{
    public class GerenciandoXmlConfiguracao
    {
        private static string NomeArquivo = "Configuracao";

        private static XmlDocument _xmlConfiguracao;

        public GerenciandoXmlConfiguracao() 
        {
            InstanciarXML();
        }

        public  XmlDocument GetXMlConfiguracao()
        {
             return _xmlConfiguracao;
        } 

        private  void InstanciarXML()
        {
            if(!validarExistenciaAquivoConfiguracao())
                                         CriarXmlPadrao();

            _xmlConfiguracao = new XmlDocument();
            _xmlConfiguracao.Load($"{NomeArquivo}.xml");
        }
        private static bool validarExistenciaAquivoConfiguracao()
        {
            return File.Exists($"{NomeArquivo}.xml");
        }
        private static bool CriarXmlPadrao()
        {
            try
            {
                _xmlConfiguracao = new XmlDocument();

                XmlSerializer serializar = new XmlSerializer(typeof(ArqConfiguracao));

                StringWriter xml  = new StringWriter();

                var dados = GetConfiguracao();

                serializar.Serialize(xml, dados);

                string xmlString = xml.ToString();

                _xmlConfiguracao.LoadXml(xmlString);

                _xmlConfiguracao.Save($"{NomeArquivo}.xml");


                if (validarExistenciaAquivoConfiguracao())
                    return true;

                else
                    return false;


            }
            catch (Exception ex) { throw ex; }
           
        }
        private static ArqConfiguracao GetConfiguracao()
        {
            var conf = new ArqConfiguracao();
            conf.ConexaoBancoDados = new ConfiguracaoConexaoBancoDados();
            conf.API = new ConfiguracaoAPI();


            conf.ConexaoBancoDados.Banco = "Perron";
            conf.ConexaoBancoDados.Instancia = @"ADANLUCAS-PC\META";
            conf.ConexaoBancoDados.Usuario = "sa";
            conf.ConexaoBancoDados.Senha = @"kb74Uwfcq/DRfmAGZd8pkghc52rMpXAGBZXVQOr4pkpIpsK5nt6pDCJE+EF+47wZY8aX87eqCtt/F9vjKBHMNk8jJ/2oVXOtGBcUEMn9cb1txI0Fiv7N+LFzgcfWGJuW";
            conf.API.Porta = 50000;
            conf.API.Ip = "127.0.0.1";


            return conf;
        }
    }
}
