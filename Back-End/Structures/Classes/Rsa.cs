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
        public static string Decrypt(RSAParameters RSAParams, string encryptedString)
        {
            return Encoding.UTF8.GetString(Decrypt(Encoding.ASCII.GetBytes(encryptedString), RSAParams, true));
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