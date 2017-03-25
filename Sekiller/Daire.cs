using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Daire
    {
        private int r { get; set; }
        private const double pi= Math.PI;

        public Daire(int yaricap)
        {
            this.r = yaricap;
        }

        public double Alan()
        {
            double alan = pi * (Math.Pow(r, 2));
            return alan;
        }

        public double Cevre()
        {
            double cevre = 2 * pi * r;
            return cevre;
        }
    }
}
