using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matris = { {1,5,7,8},
                              {3,5,2,0},
                              {6,3,4,1},
                              {7,4,2,0}};

            Matris(matris);

            SatirTopla(ref matris);

            Console.WriteLine();

            SutunTopla(ref matris);

            Console.WriteLine($"\nMatrisin diyagonel toplamı: {diyagonTopla(matris)}");
            Console.WriteLine($"\nMatrisin diyagonel toplamı: {tersdiyagonelTopla(matris)}\n");
        }

        static void Matris(int[,] matris)
        {
            for(int i=0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write($"{matris[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static int diyagonTopla(int[,] matris)
        {
            int toplam = 0;
            for(int i=0;i<((matris.GetLength(1)<matris.GetLength(0))? matris.GetLength(1):matris.GetLength(0));i++)
            {
                toplam += matris[i,i];
            }
            return toplam;

            //for (int row = 0; row < matris.GetLength(0); row++)
            //{
            //    for (int column = 0; column > matris.GetLength(1); column++)
            //    {
            //        if(row==column)
            //        toplam = toplam + matris[row, column];

            //    }
            //}


        }

        static int tersdiyagonelTopla(int[,] matris)
        {
            int toplam = 0;
            for (int row = 0; row < matris.GetLength(0); row++)
            {
                for (int column = matris.GetLength(1); column >= 0; column--)
                {
                    if (row + column == 3)
                        toplam = toplam + matris[row, column];

                }
            }
            return toplam;
        }

        static void SatirTopla(ref int[,] matris) //CallbyReference
        {
            int toplam = 0;
            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0; j < matris.GetLength(1); j++)
                {
                    toplam += matris[i, j];
                }
                Console.WriteLine($"{i+1}.satır toplamı : {toplam}");
                toplam = 0;
            }
        }

        static void SutunTopla(ref int[,] matris)
        {
            int toplam = 0;
            for (int i = 0; i < matris.GetLength(1); i++)
            {
                for (int j = 0; j < matris.GetLength(0); j++)
                {
                    toplam += matris[j, i];
                }
                Console.WriteLine($"{i+1}.sutun toplamı : {toplam}");
                toplam = 0;
            }
        }
    }

}
