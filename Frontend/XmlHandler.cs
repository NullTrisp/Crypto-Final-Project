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
            parsedDoc.LoadXml(WebUtility.HtmlDecode(doc.InnerXml));
            return parsedDoc;
        }

        public static PrivateKey LoadPrivateKeyXml(string path)
        {
            var doc = LoadXml(path);
            var PK = new PrivateKey()
            {
                Modulus = doc.SelectSingleNode("//Modulus").InnerText,
                Exponent = doc.SelectSingleNode("//Exponent").InnerText,
                P = doc.SelectSingleNode("//P").InnerText,
                Q = doc.SelectSingleNode("//Q").InnerText,
                DP = doc.SelectSingleNode("//DP").InnerText,
                DQ = doc.SelectSingleNode("//DQ").InnerText,
                InverseQ = doc.SelectSingleNode("//InverseQ").InnerText,
                D = doc.SelectSingleNode("//D").InnerText
            };

            return PK;
        }
    }
}
