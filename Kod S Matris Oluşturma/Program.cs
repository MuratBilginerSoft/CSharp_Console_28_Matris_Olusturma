using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Matris_Oluşturma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrisin Satır Sayısını giriniz: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Matrisin Sütun Sayısını giriniz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[m, n];
            int[,] devrikA = new int[n, m];

            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = r.Next(10);
                    devrikA[j, i] = A[i, j];
                }
            }

            //A Matrisi ekrana yazıldı

            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
