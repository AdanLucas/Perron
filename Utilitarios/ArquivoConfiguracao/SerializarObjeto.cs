using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Utilitarios.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Utilitarios.ArquivoConfiguracao
{
    public static class SerializarObjeto
    {
        public static ArqConfiguracao DeserializarXml(XmlDocument xml)
        {
            using (XmlNodeReader reader = new XmlNodeReader(xml.DocumentElement))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ArqConfiguracao));
                ArqConfiguracao conf = (ArqConfiguracao)serializer.Deserialize(reader);

                return conf;
            }
        }
    }
}
