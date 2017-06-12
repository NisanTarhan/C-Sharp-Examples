using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuickSort_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit;
            do
            {
                Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
                int eleman_sayısı = int.Parse(Console.ReadLine());
                int[] dizi = new int[eleman_sayısı];
                Random rand = new Random();
                Stopwatch sw = new Stopwatch();

                for (int i = 0; i < eleman_sayısı; i++)
                {
                    dizi[i] = rand.Next() % 100;
                }


                if (eleman_sayısı <= 30)
                {
                    Console.WriteLine("\nDizi\n");
                    for (int i = 0; i < eleman_sayısı; i++)
                    {
                        Console.Write(dizi[i]);
                        Console.Write(" ");
                    }
                }


                Console.WriteLine("\n\nQuickSort\n");
                sw.Start();
                QuickSort(dizi);
                sw.Stop();
                TimeSpan time = sw.Elapsed;
                Console.WriteLine("Geçen süre:" + time.ToString());

                if (eleman_sayısı <= 30)
                {
                    for (int i = 0; i < eleman_sayısı; i++)
                    {
                        Console.Write(dizi[i]);
                        Console.Write(" ");
                    }
                }
                
                Console.WriteLine("\nDevam etmek için 1 e basın");
                exit = int.Parse(Console.ReadLine());
            } while (exit == 1);

            Console.ReadKey();
        }

        private static void QuickSort(int[] dizi)
        {
            if (dizi.Length <= 1)
            {
                return;
            }

            Sort(dizi, 0, dizi.Length - 1);
        }

        private static void Sort(int[] dizi, int baslangic, int son)
        {
            if ((son - baslangic) <= 0)
            {
                return;
            }

            int ayirma_noktasi = Ayir(dizi, baslangic, son);
            Sort(dizi, baslangic, ayirma_noktasi - 1);
            Sort(dizi, ayirma_noktasi, son);


        }

        private static int Ayir(int[] dizi, int baslangic, int son)
        {
            int left = baslangic + 1;
            int right = son;
            int pivot = dizi[baslangic];

            while (true)
            {
                while (left <= right && dizi[left] < pivot)
                {
                    left++;
                }

                while (right > left && dizi[right] > pivot)
                {
                    right--;
                }

                if (left >= right)
                {
                    break;
                }

                int temp = dizi[left];
                dizi[left] = dizi[right];
                dizi[right] = temp;
                left++;
                right--;
            }

            dizi[baslangic] = dizi[left - 1];
            dizi[left - 1] = pivot;
            return left;
        }


        //public static void QuickSort(double[] elements, int left, int right)
        //{
        //    int i = left, j = right;
        //    double pivot = elements[(left + right) / 2];

        //    while (i <= j)
        //    {
        //        while (elements[i].CompareTo(pivot) < 0)
        //        {
        //            i++;
        //        }

        //        while (elements[j].CompareTo(pivot) > 0)
        //        {
        //            j--;
        //        }

        //        if (i <= j)
        //        {
        //            // Swap İşlemi
        //            double tmp = elements[i];
        //            elements[i] = elements[j];
        //            elements[j] = tmp;

        //            i++;
        //            j--;
        //        }
        //    }

        //    // Recursive Çağırma
        //    if (left < j)
        //    {
        //        QuickSort(elements, left, j);
        //    }

        //    if (i < right)
        //    {
        //        QuickSort(elements, i, right);
        //    }
        //}
    }
}
