using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit;
            do
            {
                Console.WriteLine("Dizi Uzunluğunu Giriniz : ");
                int uzunluk = int.Parse(Console.ReadLine());
                Console.WriteLine("Random Sayı Aralığını Belirleyiniz : ");
                int limit = int.Parse(Console.ReadLine());

                int[] dizi = new int[uzunluk];
                Random random = new Random();
                Stopwatch sw = new Stopwatch();

                for (int i = 0; i < uzunluk; i++)
                    dizi[i] = random.Next(1, limit);

                sw.Start();
                insertion_sort(dizi);
                sw.Stop();
                TimeSpan time = sw.Elapsed;
                Console.WriteLine("Geçen süre:" + time.ToString());

                //if (uzunluk <= 30)
                //{
                //    for (int i = 0; i < uzunluk; i++)
                //        Console.Write(dizi[i].ToString() + " ");
                //}
                //Console.WriteLine();

                Array.Reverse(dizi);

                //if (uzunluk <= 30)
                //{
                //    Console.Write("Dizinin Tersi : ");
                //    for (int i = 0; i < uzunluk; i++)
                //        Console.Write(dizi[i].ToString() + " ");
                //}
                //Console.WriteLine();

                sw.Start();
                insertion_sort(dizi);
                sw.Stop();
                TimeSpan time_worst = sw.Elapsed;
                Console.WriteLine("Geçen süre(Worst):" + time_worst.ToString());
                Console.WriteLine("Devam etmek için 1 e basın");
                exit=int.Parse(Console.ReadLine());
            } while (exit==1);




            //Console.ReadLine();
        }


        static void insertion_sort(int[] dizi)
        {
            for (int j = 1; j < dizi.Length; j++)
            {
                int key = dizi[j];
                int i = j - 1;
                while (i >= 0 && dizi[i] > key)
                {
                    dizi[i + 1] = dizi[i];
                    i = i - 1;
                }
                dizi[i + 1] = key;
            }
        }

        //int[] tersdizi = new int[uzunluk];

        //int eleman_degeri = uzunluk;

        //for (int i = 0; i < uzunluk; i++)
        //{
        //    tersdizi[i] = eleman_degeri;
        //    eleman_degeri--;
        //}

        //Console.WriteLine("En kötü Durum Analizi için {0} elemanlı ", uzunluk);

        //if (uzunluk <= 30)
        //{
        //    for (int i = 0; i < uzunluk; i++)
        //        Console.Write(tersdizi[i].ToString() + " ");
        //}
        //Console.WriteLine();

        //sw.Start();
        //insertion_sort(tersdizi);
        //sw.Stop();
        //TimeSpan time_worst = sw.Elapsed;
        //Console.WriteLine("Geçen süre(Worst):" + time_worst.ToString());

    }
}
