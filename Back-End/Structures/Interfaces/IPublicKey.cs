using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_End.Structures.Interfaces
{
    public interface IPublicKey
    {
        string Modulus { get; set; }
        string Exponent { get; set; }

    }
}
