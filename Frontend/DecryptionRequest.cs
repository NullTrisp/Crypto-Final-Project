using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public class DecryptionRequest
    {
        public string encryptedString { get; set; }
        public PrivateKey privateKey { get; set; }
    }
}
