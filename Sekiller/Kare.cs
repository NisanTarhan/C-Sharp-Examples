using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Kare
    {
        private int uzunluk { get; set; }
        const int kenarsayisi = 4;

        public Kare(int uzunluk)
        {
            this.uzunluk = uzunluk;
        }

        public double Alan()
        {
            double alan = Math.Pow(uzunluk, 2);
            return alan;
        }

        public double Cevre()
        {
            int cevre = kenarsayisi * uzunluk;
            return cevre;
        }
    }
}
