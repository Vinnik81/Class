using System;
using System.Linq;

namespace HomeWork_3
{
    class Program
    {
        public static void MinMax(float[,] B, out float min, out float max)
        {
            min = B[0, 0];
            max = B[0, 0];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (min > B[i, j]) min = B[i, j];
                    if (max < B[i, j]) max = B[i, j];
                }
            }
        } 
        public static void MinMax(int[,] Arr, out int min, out int max)
        {
            min = Arr[0, 0];
            max = Arr[0, 0];
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (min > Arr[i, j]) min = Arr[i, j];
                    if (max < Arr[i, j]) max = Arr[i, j];
                }
            }
        }
        public static float Sum(float[,] B, out float sum)
        {
            sum = 0;
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    sum += B[i, j];
            return sum;
        }
        public static int Mul(int[]A, out int mul)
        {
            mul = 1;
            for (int i = 0; i < A.Length; i++) mul *= A[i];
            return mul;
        }
        public static float Mul(float[,]B, out float _mul)
        {
            _mul = 1;
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    _mul *= B[i, j];
            return _mul;
        }
            static void Main(string[] args)
        {
            //Task 1
            //int[] A = new int[5];
            //int _sum = 0;
            //float sum2 = 0.0f;
            //Console.WriteLine($"Введите значение элементов массива A:");
            //for (int i = 0; i < A.Length; i++) A[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Массив A: ");
            //foreach (int num in A) Console.Write($"{num}" + " ");
            //float[,] B = new float[3, 4];
            //Random random = new Random();
            //Console.WriteLine($"\nМассив B: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        B[i, j] = (float)random.NextDouble();
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write($"\nМаксимальный злемент массива A: {A.Max()}");
            //Console.Write($"\nМинимальный элемент массива A: {A.Min()}");
            //MinMax(B, out float min, out float max);
            //Console.Write($"\nМаксимальный злемент массива B: {max}");
            //Console.Write($"\nМинимальный элемент массива B: {min}");
            //Console.Write($"\nСумма всех элементов массива A: {A.Sum()}");
            //Console.WriteLine($"\nСумма всех элементов массива B: {Sum(B, out float sum)}");
            //Console.Write($"\nПроизведение всех элементов массива A: {Mul(A, out int mul)}");
            //Console.Write($"\nПроизведение всех элементов массива B: {Mul(B, out float _mul)}");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] % 2 == 0) _sum += A[i];
            //}
            //Console.Write($"\nСумма чётных элементов массива A: {_sum}");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if (B[i, 0] % 2 != 0) sum2 += B[i, 0];
            //    }
            //}
            //Console.Write($"\nСумма нечётных элементов массива B: {sum2}");

            //Task 2
            //const int M = 10;
            //const int N = 12;
            //Random random = new Random();
            //int[] arr = new int[M];
            ////Console.WriteLine($"Введите эелементы первого массива: ");
            //for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(89);
            //Console.WriteLine($"Первый массив: ");
            //foreach (int num in arr) Console.Write($"{num}\t");
            //int[] brr = new int[N];
            ////Console.WriteLine($"\nВведите эелементы второго массива: ");
            //for (int i = 0; i < brr.Length; i++) brr[i] = random.Next(100);
            //Console.WriteLine($"\nВторой массив: ");
            //foreach (int num in brr) Console.Write($"{num}\t");
            //int count = 0;
            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (arr[i] == brr[j]) count++;
            //    }
            //}
            //Console.Write($"\nКоличество совпадений: {count}");
            //int p = count;
            //int[] crr = new int[p];
            //p = 0;
            //for (int j = 0; j < N; j++)
            //{
            //    for (int k = 0; k < M; k++)
            //    {
            //        if (brr[j] == arr[k])
            //        {
            //            crr[p] = brr[j];
            //            p++;
            //        }
            //    }
            //}
            //Console.WriteLine($"\nРезультирующий масиив: ");
            //for (int i = 0; i < p; i++) Console.Write($"{crr[i]}\t");

            //Task 3
            //Console.WriteLine($"Введите строку: ");
            //string str = Console.ReadLine();
            //bool poli = true;
            //str = str.Replace(" ", string.Empty);
            //for (int i = 0; i < str.Length / 2; i++)
            //{
            //    if (str[i] != str[str.Length - i - 1]) poli = false;
            //}
            //Console.WriteLine(((poli) ? "является " : "не является ") + "палиндромом");

            //Task 4
            //string[] word;
            //Console.WriteLine($"Введите строку: ");
            //string str = Console.ReadLine();
            //word = str.Split(' ');
            //Console.Write($"\nКоличество слов в строке: {word.Length}");

            //Task 5
            int[,] Arr = new int[5, 5];
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++) Arr[i, j] = random.Next(-100, 100);
            }
            Console.WriteLine($"Двумерный массив: ");
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++) Console.Write($" {Arr[i, j]}");
                Console.WriteLine();
            }
            MinMax(Arr, out int min, out int max);
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Arr[i, j] > min && Arr[i, j] < max) sum += Arr[i, j];
                }
            }
            Console.Write($"Сумма элементов массива находящихся между min и max: {sum}");
        }
    }
}
