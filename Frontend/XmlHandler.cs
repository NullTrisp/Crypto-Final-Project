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
        public string Path { get; set; }
        private XmlDocument LoadXml()
        {
            var doc = new XmlDocument();
            doc.Load(this.Path);

            var parsedDoc = new XmlDocument();
            parsedDoc.LoadXml(doc.InnerXml);
            return parsedDoc;
        }

        public string LoadPrivateKey()
        {
            return LoadXml().SelectSingleNode("//clavePrivada").InnerText;
        }
    }
}
