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
                return Rsa.Decrypt(new RSAParameters()
                {
                    Exponent = Encoding.ASCII.GetBytes(req.privateKey.Exponent),
                    Modulus = Encoding.ASCII.GetBytes(req.privateKey.Modulus),
                    P = Encoding.ASCII.GetBytes(req.privateKey.P),
                    Q = Encoding.ASCII.GetBytes(req.privateKey.Q),
                    DP = Encoding.ASCII.GetBytes(req.privateKey.DP),
                    DQ = Encoding.ASCII.GetBytes(req.privateKey.DQ),
                    InverseQ = Encoding.ASCII.GetBytes(req.privateKey.InverseQ),
                    D = Encoding.ASCII.GetBytes(req.privateKey.D),
                }, req.encryptedString);
            } catch(Exception ex)
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