using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RSA
    {
        public static string Decrypt(string privateKey, string encryptedString)
        {
            byte[] decryptedData;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            rsa.FromXmlString(privateKey);
            rsa.ImportParameters(new RSAParameters()
            {
                Modulus = Encoding.ASCII.GetBytes("t3wHJ20FIxJLF862VXhdJVKJBrNuPHYzNgVEoplwaqZCXg85Y1UBcWsLFo2z2Kw2+inuFQq7i0nWPc5HdbsarJO4QMl6+p8QO4vggvRe/LyOLu2F9woSy22jcCywN7UM8cX5aKcVy5eKYjRXtCarda1gQAp4+JH/y3KsQYwOkP0="),
            });

            var encryptedData = Encoding.ASCII.GetBytes(encryptedString);
            decryptedData = rsa.Decrypt(encryptedData, true);

            return Encoding.UTF8.GetString(decryptedData);
        }

        private static byte[] Decryption(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                decryptedData = rSACryptoServiceProvider.Decrypt(data, fOAEP);
            }
            return decryptedData;
        }
    }
}
