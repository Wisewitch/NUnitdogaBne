using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_dolgozat_Bne
{
    public class Jaratkezelo
    {
        private class Jarat {
            private string jaratszam;
            private string honnanrepter;
            private string hovarepter;
            private DateTime indulas;
            private int keses;

            public Jarat(string jaratszam, string honnanrepter, string hovarepter, DateTime indulas)
            {
                this.jaratszam = jaratszam;
                this.honnanrepter = honnanrepter;
                this.hovarepter = hovarepter;
                this.indulas = indulas;
                this.keses = 0;
            }

            public string Jaratszam { get => jaratszam; set => jaratszam = value; }
            public string Honnanrepter { get => honnanrepter; set => honnanrepter = value; }
            public string Hovarepter { get => hovarepter; set => hovarepter = value; }
            public DateTime Indulas { get => indulas; set => indulas = value; }
            public int Keses { get => keses; set => keses = value; }
        }


        List<Jarat> jaratok;  

        public Jaratkezelo() {
            jaratok = new List<Jarat>();
            var date = new DateTime();
        }

        private Jarat Jaratkeres(string jaratszam)
        {
            foreach (var jarat in jaratok) {
                if (jarat.Jaratszam == jaratszam) {
                    return jarat;
                }
                throw new HibasjaratszamException(jaratszam);
            }
        
        }

        public void UjJarat(string jaratszam, string honnanrepter, string hovarepter, DateTime indulas) {
            int keses = 0;
            try
            {
                Jaratkeres(jaratszam, keses);
                throw new ArgumentException("A megadott járatszám már létezik", "jaratszam");
            }
            catch (NegativKesesException)
            {

                var jarat = new Jarat(jaratszam, honnanrepter, hovarepter, indulas);
                jaratok.Add(jarat);

            }
           

        }

        public int Keses(string jaratszam, int keses) {
            var jarat = Jaratkeres(jaratszam, keses);
            return jarat.Keses;
        }

        public void OsszesKeses(string jaratszam, int percek)
        {
            var jarat = Jaratkeres(jaratszam, percek);
            jarat.Keses += percek;
        }

        public void MikorIndul(string jaratszam, string honnan, DateTime indulas) {

          var jarat = Jaratkeres(jaratszam);
            int ora;
            int perc; 


        }

        public void JaratokRepuloterrol(string repter, string honnan, string hova)
        {
            var honnanrepter = Jaratkeres(honnan);
            var hovarepter = Jaratkeres(hova);
           
            honnanrepter.Keses -= percek;
            hovarepter.Keses += percek;

        }

}
}
