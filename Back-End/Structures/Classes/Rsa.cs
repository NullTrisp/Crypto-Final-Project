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
        public static string Decrypt(byte[] Data, RSAParameters RSAKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            RSAParameters key = RSAKey;
            byte[] text = Data;
            byte[] resultado = Decrypt(text, key, false);
            return Encoding.Default.GetString(resultado);
        }

        private static byte[] Decrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            byte[] decryptedData;
            //Create a new instance of RSACryptoServiceProvider.
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
            {
                //Import the RSA Key information. This needs
                //to include the private key information.
                RSA.ImportParameters(RSAKeyInfo);

                //Decrypt the passed byte array and specify OAEP padding.  
                //OAEP padding is only available on Microsoft Windows XP or
                //later.  
                decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
            }
            return decryptedData;
        }
    }
}