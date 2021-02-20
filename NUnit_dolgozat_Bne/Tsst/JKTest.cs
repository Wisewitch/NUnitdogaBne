using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit_dolgozat_Bne.Tsst
{
    [TestFixture]
    class JKTest
    {
        Jaratkezelo jk;
        [SetUp]

        public void SetUp()
        {
            jk = new Jaratkezelo();
        }

        [TestCase]
        public void UjjaratFelvesz() {
            
            jk.UjJarat("LH252", "BER", "BUD", "2021-02-25 12:25:00");
            int keses = 0;

        }

        public void 


    }
}
