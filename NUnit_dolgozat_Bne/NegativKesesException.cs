using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_dolgozat_Bne
{
    class NegativKesesException : Exception
    {
        public NegativKesesException(string jaratszam, int keses)
            : base("Hibás késés adat: a késés nem lehet negatív! " + jaratszam + keses)
        { }
    }
    }
