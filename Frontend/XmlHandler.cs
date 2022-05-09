using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Frontend
{
    class XmlHandler
    {
        public static XmlElement LoadXml(string path)
        {
            var doc = new XmlDocument();
            doc.Load(path);
            return doc.DocumentElement;
        }

        public static string LoadPrivateKeyXml(string path)
        {
            var doc = LoadXml(path);
            return doc.SelectSingleNode("//clavePrivada").InnerText;
        }
    }
}
