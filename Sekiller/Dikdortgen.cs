using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Dikdortgen
    {
        private int uzunkenar { get; set; }
        private int kisakenar { get; set; }

        public Dikdortgen(int uzunkenar,int kisakenar)
        {
            this.uzunkenar = uzunkenar;
            this.kisakenar = kisakenar;
        }

        public double Alan()
        {
            double alan = uzunkenar * kisakenar;
            return alan;
        }

        public int Cevre()
        {
            int cevre = 2 * (uzunkenar + kisakenar);
            return cevre;
        }
    }
}
