using Back_End.Structures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_End.Structures.Classes
{
    public class PrivateKey : IPrivateKey
    {
        public string Modulus { get; set; }
        public string Exponent { get; set; }
        public string P { get; set; }
        public string Q { get; set; }
        public string DP { get; set; }
        public string DQ { get; set; }
        public string InverseQ { get; set; }
        public string D { get; set; }
    }
}