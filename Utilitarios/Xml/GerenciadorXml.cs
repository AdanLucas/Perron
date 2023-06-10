using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Utilitarios.Xml
{
    public class GerenciadorXml<T>
    {
        private XmlDocument _xml;
        T XmlBase { get; set; }

        private string _nomeArquivo { get; set; }
        public GerenciadorXml(string nomeXml,T obj) 
        {
            _nomeArquivo = nomeXml;
            XmlBase = obj;
            InstanciarXML();
        }

        public  XmlDocument GetXMlConfiguracao()
        {
             return _xml;
        } 
        private  void InstanciarXML()
        {
            if(!validarExistenciaAquivoConfiguracao())
                                                CriarXml();

            _xml = new XmlDocument();
            _xml.Load(_nomeArquivo);

        }
        private  bool validarExistenciaAquivoConfiguracao()
        {
            return File.Exists(_nomeArquivo);
        }
        private  bool CriarXml()
        {
            try
            {
                _xml = new XmlDocument();
                XmlSerializer serializar = new XmlSerializer(typeof(T));
                StringWriter xml  = new StringWriter();
                serializar.Serialize(xml,XmlBase);
                string xmlString = xml.ToString();
                _xml.LoadXml(xmlString);
                _xml.Save(_nomeArquivo);


                if (validarExistenciaAquivoConfiguracao())
                    return true;

                else
                    return false;


            }
            catch (Exception ex) { throw ex; }
           
        }
       
    }
}
