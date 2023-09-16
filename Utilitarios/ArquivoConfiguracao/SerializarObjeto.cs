using System.Xml;
using System.Xml.Serialization;

namespace Utilitarios.ArquivoConfiguracao
{
    public static class SerializarObjeto
    {
        public static T DeserializarXml<T>(XmlDocument xml)
        {
            using (XmlNodeReader reader = new XmlNodeReader(xml.DocumentElement))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ArqConfiguracao));
                T conf = (T)serializer.Deserialize(reader);

                return conf;
            }
        }
    }
}
