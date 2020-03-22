using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // первое задание
            Console.WriteLine("Первое задание");
            Arrs arrs = new Arrs();
            int[] A = new int[5],
                  B = new int[5],
                  C = new int[5];

            Arrs.CreateOneDimAr(A);
            Arrs.CreateOneDimAr(B);

            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
            }

            int[] X = { 5, 5, 6, 6, 7, 7 };

            int[] U, V;

            U = new int[3] { 1, 2, 3 };
            V = U;
            V[0] = 9;
            Arrs.PrintArr1("A", A);
            Arrs.PrintArr1("B", B);
            Arrs.PrintArr1("C", C);
            Arrs.PrintArr1("X", X);
            Arrs.PrintArr1("U", U);
            Arrs.PrintArr1("V", V);
            Console.WriteLine("Введите размер массива D");
            int Size = int.Parse(Console.ReadLine());
            int[] D = new int[Size];
            Arrs.CreateOneDimAr(D);
            Arrs.PrintArr1("D", D);
            Console.WriteLine();
            // второе задание
            Console.WriteLine("Второе задание");
            Console.WriteLine("Введите m");
            int FirstSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            int SecondSize = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[FirstSize, SecondSize];
            int[,] arr2 = new int[SecondSize, FirstSize];
            Arrs.CreateAr2(arr1);
            Arrs.CreateAr2(arr2);
            int[,] arr3 = Arrs.MultMutr(arr1, arr2);
            Arrs.PrintArr2("arr1", arr1);
            Arrs.PrintArr2("arr2", arr2);
            Arrs.PrintArr2("arr3", arr3);
            Console.WriteLine();
            // третье задание
            Console.WriteLine("Третье задание");
            Console.WriteLine("Введите длинну массива массивов");
            int lenght = int.Parse(Console.ReadLine());
            int[][] arrArr = new int[lenght][];
            Arrs.CreateArr3(arrArr);
            Arrs.PrintArr3("arrArr", arrArr);
            Console.WriteLine();
        }
    }

    class Arrs
    {
        private static Random rnd;

        public Arrs()
        {
            rnd = new Random();
        }
        public static int[,] MultMutr(int[,] matr1, int[,] matr2)
        {
            int m = matr1.GetLength(0);
            int kk = matr2.GetLength(0);
            int n = matr2.GetLength(1);
            int[,] result = new int[m, n];
            if (matr1.Length == matr2.Length)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < kk; k++)
                            result[i, j] += matr1[i, k] * matr2[k, j];
                    }
                }
            }
            return result;
        }
        public static void CreateOneDimAr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }
        }

        public static void CreateAr2(int[,] arr)
        {
            int first = arr.GetLength(0);
            int second = arr.GetLength(1);
            for (int i = 0; i < first; i++)
            {
                for (int j = 0; j < second; j++)
                {
                    arr[i, j] = rnd.Next(1, 11);
                }
            }
        }
        public static void CreateArr3(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int[] D = new int[i + 1];
                Arrs.CreateOneDimAr(D);
                arr[i] = D;

            }
        }

        public static void PrintArr1(string name, int[] arr)
        {
            Console.WriteLine(name);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("elem[{0}] = {1}", i, arr[i]);
            }
        }

        public static void PrintArr2(string name, int[,] arr)
        {
            int first = arr.GetLength(0);
            int second = arr.GetLength(1);
            Console.WriteLine(name);
            for (int i = 0; i < first; i++)
            {
                for (int j = 0; j < second; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }


        public static void PrintArr3(string name, int[][] arr)
        {
            Console.WriteLine(name);
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0} ", arr[i][j]);
                }
                System.Console.WriteLine();
            }
        }

       
    }
}
