using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Frontend
{
    class XmlHandler
    {
        public static XmlDocument LoadXml(string path)
        {
            var doc = new XmlDocument();
            doc.Load(path);

            var parsedDoc = new XmlDocument();
            parsedDoc.LoadXml(doc.InnerXml);
            return parsedDoc;
        }

        public static string LoadPrivateKey(string path)
        {
            return LoadXml(path).SelectSingleNode("//clavePrivada").InnerText;
        }
    }
}
