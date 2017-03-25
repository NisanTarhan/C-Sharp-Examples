using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            do
            {
                Console.WriteLine("Kare için : kare    Üçgen için : üçgen      " +
                                   "Dikdörtgen için : dikdörtgen     Daire için = daire    Çıkmak için : exit");

                name = Console.ReadLine();

                switch (name)
                {
                    case "kare":
                        Kare();
                        break;
                    case "üçgen":
                        Ucgen();
                        break;
                    case "dikdörtgen":
                        Dikdortgen();
                        break;
                    case "daire":
                        Daire();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem");
                        break;                       
                }
            } while (name != "exit");
           
                    
        }



        static void Kare()
        {
            Console.WriteLine("Kenar uzunluğu değerini giriniz: ");
            var uzunluk = Convert.ToInt32(Console.ReadLine());

            Kare kare = new Kare(uzunluk);
            Console.WriteLine("Karenin kenar uzunluğu = {0}  Karenin Alanı = {1}  Karenin çevresi = {2}\n", uzunluk, kare.Alan(), kare.Cevre());
        }

        static void Ucgen()
        {

            //int[] kenar = new int[3];
            //Console.WriteLine("\nÜçgenin kenarlarını giriniz : ");

            //int i = 0;
            //int toplam = 0;
            //do
            //{

            //    Console.Write($"\n{i + 1}.kenar degerini giriniz = ");
            //    kenar[i] = Convert.ToInt32(Console.ReadLine());
            //    toplam += kenar[i];
            //    i++;
            //} while (i != 3);

            Console.Write("\nDiküçgenin Birinci Kenar Uzunluğu = ");
            var kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDiküçgenin İkinci Kenar Uzunluğu = ");
            var kenar2 = Convert.ToInt32(Console.ReadLine());

            Ucgen ucgen = new Ucgen(kenar1, kenar2);
            Console.WriteLine("\nÜçgenin Alanı = {0}  Üçgenin Çevresi = {1}\n", ucgen.Alan(), ucgen.Cevre());

        }

        static void Dikdortgen()
        {
            Console.Write("Dikdörtgenin Uzun Kenarı = ");
            int uzunkenar = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDikdörtgenin Kısa Kenarı = ");
            int kisakenar = Convert.ToInt32(Console.ReadLine());

            Dikdortgen dikdortgen = new Dikdortgen(uzunkenar, kisakenar);
            Console.WriteLine("\nDikdörtgenin Alanı = {0}  Dikdörtgenin Çevresi = {1}\n", dikdortgen.Alan(), dikdortgen.Cevre());
        }

        static void Daire()
        {           
            Console.WriteLine("\nDairenin veya Çemberin Yariçapını Giriniz :");
            int yaricap = Convert.ToInt32(Console.ReadLine());
            Daire daire = new Daire(yaricap);
            Console.WriteLine("\nDairenin Alanı = {0}   Çemberin Alanı = {1}", daire.Alan(), daire.Cevre());
        }
    }
}
