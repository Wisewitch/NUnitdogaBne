using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_dolgozat_Bne
{
    class HibasjaratszamException : Exception
    {
        public HibasjaratszamException(string jaratszam)
            : base("Hibás járatszám:   " + jaratszam)
        { }
    }
}
