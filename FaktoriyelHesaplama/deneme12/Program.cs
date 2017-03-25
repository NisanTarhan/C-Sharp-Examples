using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme12
{
    class Program
    {
        static void Main(string[] args)
        {
            for(long sayac=1;sayac<=10;++sayac)
            {
                Console.WriteLine($"{sayac}! = {Faktoriyel(sayac)}");
            }
            Console.ReadKey();
        }

        static long Faktoriyel (long number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Faktoriyel(number - 1);
        }
    }
}
