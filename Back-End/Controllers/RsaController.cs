using Back_End.Structures.Classes;
using Back_End.Structures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;

namespace Back_End.Controllers
{
    public class RsaDecryptRequest
    {
        public PrivateKey privateKey { get; set; }
        public string encryptedString { get; set; }
    }
    public class RsaController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public string Post([FromBody] RsaDecryptRequest req)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString("<ALGORITMO><clave><ALGORITMOKeyValue><Modulus>t3wHJ20FIxJLF862VXhdJVKJBrNuPHYzNgVEoplwaqZCXg85Y1UBcWsLFo2z2Kw2+inuFQq7i0nWPc5HdbsarJO4QMl6+p8QO4vggvRe/LyOLu2F9woSy22jcCywN7UM8cX5aKcVy5eKYjRXtCarda1gQAp4+JH/y3KsQYwOkP0=</Modulus><Exponent>AQAB</Exponent></ALGORITMOKeyValue></clave><clavePrivada><ALGORITMOKeyValue><Modulus>t3wHJ20FIxJLF862VXhdJVKJBrNuPHYzNgVEoplwaqZCXg85Y1UBcWsLFo2z2Kw2+inuFQq7i0nWPc5HdbsarJO4QMl6+p8QO4vggvRe/LyOLu2F9woSy22jcCywN7UM8cX5aKcVy5eKYjRXtCarda1gQAp4+JH/y3KsQYwOkP0=</Modulus><Exponent>AQAB</Exponent><P>7JpuVJ4+3ZH4L8Q4DywYw4R7MphshRx39Nkb1dI3y9lGmDWtC4DY9MsuE5FeUNbyM1hizusubCtTECv6PV3Q2w==</P><Q>xobMenFpgAaWP9eZsHPm4g7tMDe66hg9gLEpB1ClsYt7WNyjsjAqjNAcyOrOEmDct2cr+nz51Wu5YPkWRxcBBw==</Q><DP>Vr8YDHYoXlwSPpEWbJmiSqzb7mTsBLG3WVHwXqjAREDZHR0w4LLQ2I9VyV7W0ZS9IA4by/l1/7qyrY8yJCWtWQ==</DP><DQ>p3PmH9VvppRnwXvq38IzWjQ67rPjTjeaEOXd9JSa3jIHncGltdQY3+NelD4yCaB4K56zorotxU3y9I/Fsbr+mw==</DQ><InverseQ>ssbEa+0/f0XuO19mhcuO0U+tTYwjR9tFNBL2rjXlVkQsv8jnqAY22oZwwEK6vgqd+qaDTFtbc5qxIwqGKaqvqA==</InverseQ><D>qEYPKZFKTMfSJptljS09/6SaFpMoXjro7HoYYCboembQJwM/VmH3WNUa7iw27FfEc9lQh+u35B5rZXNxBf/6jQw8dTccheuUniZ2uS3ump4gj0VXSHZ3hx5pttbWhA7XKEbRSZS64OV8yKPCqdgOkLmeNfG+Qc38wm/cVJLr5eE=</D></ALGORITMOKeyValue></clavePrivada></ALGORITMO>");
                    return Rsa.Decrypt(Encoding.ASCII.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String(req.encryptedString))s), rsa.ExportParameters(true));
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}