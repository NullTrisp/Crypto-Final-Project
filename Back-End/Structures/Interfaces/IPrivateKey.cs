using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_End.Structures.Interfaces
{
    public interface IPrivateKey
    {
        string Modulus { get; set; }
        string Exponent { get; set; }
        string P { get; set; }
        string Q { get; set; }
        string DP { get; set; }
        string DQ { get; set; }
        string InverseQ { get; set; }
        string D { get; set; }
    }
}
