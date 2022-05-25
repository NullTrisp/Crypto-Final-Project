using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Back_End.Structures.Classes
{
    public class Rsa
    {
        public static string Encrypt(string textToEncrypt, string key)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            rsa.FromXmlString(key);

            return Base64Encode(Convert.ToBase64String(
                rsa.Encrypt(
                    Convert.FromBase64String(Base64Encode(textToEncrypt)),
                    false)
                ));
        }

        public static string Decrypt(string encryptedString, string Params)
        {
            return Encoding.Default.GetString(
                Decrypt(
                    Convert.FromBase64String(
                        Base64Decode(encryptedString)
                        ),
                    Params,
                    false)
                );
        }

        private static byte[] Decrypt(byte[] DataToDecrypt, string RSAKeyInfo, bool DoOAEPPadding)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(RSAKeyInfo);

                decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
            }
            return decryptedData;
        }

        private static string Base64Decode(string encodedData)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encodedData));
        }

        private static string Base64Encode(string dataToEncode)
        {
            return Convert.ToBase64String(Encoding.Default.GetBytes(dataToEncode));
        }
    }
}