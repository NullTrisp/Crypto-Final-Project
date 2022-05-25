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
        public string privateKey { get; set; }
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
        [Route("api/Rsa/Decrypt")]
        public string Decrypt([FromBody] RsaDecryptRequest req)
        {
            try
            {
                return Rsa.Decrypt(req.encryptedString, req.privateKey);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        // POST api/<controller>
        [Route("api/Rsa/Encrypt")]
        public string Encrypt([FromBody] RsaDecryptRequest req)
        {
            try
            {
                return Rsa.Encrypt(req.encryptedString, req.privateKey);
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