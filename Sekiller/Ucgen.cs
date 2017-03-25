using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Ucgen
    {
        private int kenar1 { get; set; }
        private int kenar2 { get; set; }

        public Ucgen(int yukseklik,int taban)
        {
            
            this.kenar1 = yukseklik;
            this.kenar2 = taban;
        }

        public double Alan()
        {           
            double alan = (kenar1*kenar2)/2;
            return alan;
        }

        public float Cevre()
        {
            float Hipotenus = (float)Math.Sqrt(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2));
            float cevre = kenar1 + kenar2 + Hipotenus;
            return cevre;
        }
    }
}
