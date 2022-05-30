using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Rsa
    {
        public string Key { get; set; }
        public string Txt { get; set; }

        public string Encrypt()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            rsa.FromXmlString(this.Key);

            return Base64Encode(Convert.ToBase64String(
                rsa.Encrypt(
                    Convert.FromBase64String(Base64Encode(this.Txt)),
                    false)
                ));
        }

        public string Decrypt()
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(this.Key);

                decryptedData = RSA.Decrypt(
                    Convert.FromBase64String(
                        Base64Decode(this.Txt)
                        ), false);
            }

            return Encoding.Default.GetString(decryptedData);
        }

        private string Base64Decode(string encodedData)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encodedData));
        }

        private string Base64Encode(string dataToEncode)
        {
            return Convert.ToBase64String(Encoding.Default.GetBytes(dataToEncode));
        }
    }
}
