using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork_1_2
{
    internal class Program
    {
        /// <summary>
        /// Входная точка
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WindowWidth = 65;
            Console.BufferWidth = 65;
            while (true)
            {
                Console.WriteLine("\n >======================================<");
                Console.WriteLine("\tВыберите задание");
                Console.WriteLine("\t1 >>> Задание 1");
                Console.WriteLine("\t2 >>> Задание 2");
                Console.WriteLine("\t3 >>> Задание 3");
                Console.WriteLine("\n\t0 >>> Выход");
                Console.WriteLine(" >======================================<");
                Console.Write("\tВведите номер задания: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Exercise1();
                        break;
                    case "2":
                        Exercise2(new int[] { 0, 1, 2, 3 });
                        break;
                    case "3":
                        Exercise3();
                        break;
                    case "0":
                        Console.Clear();
                        return;
                }
                Console.Clear();
            }
        }
        /// <summary>
        /// тест проверки алгоритма 
        /// </summary>
        static void Exercise1()
        {
            int[] ansver = new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43,
                47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            for (int i = 1; i < 100; i++)
            {
                if (Exercise1_2(i) == "Простое")
                {
                    if (Array.IndexOf(ansver, i) == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\tTEST NOT complit! i = " + i);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadLine();
                        return;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tTEST complit!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadLine();
        }
        /// <summary>
        /// метод соглавсно блок схеме 
        /// </summary>
        /// <param name="n">проверяемое число</param>
        /// <returns>результат проверки</returns>
        static string Exercise1_2(int n)
        {
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                return "Простое";
            }
            else
            {
                return "Не простое";
            }
        }
        /// O(N^3);
        static int Exercise2(int[] inputArray) /// O(N^3);
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;
        }
        /// <summary>
        /// метод проверки. Метод-Тест
        /// </summary>
        static void Exercise3()
        {
            int[,] testNum = new int[,] { { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 } };
            for (int i = 0; i < testNum.GetLength(0); i++)
            { 
                if (testNum[1, i] != Exercise3_1(testNum[0, i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tTEST NOT complit! i = " + i);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                    return;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tTEST complit!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }
        /// <summary>
        /// вычисление Фибоначчи
        /// получаем число Фибоначчи по формуле  F = F - 1 + F - 2; с использование рекурсии
        /// </summary>
        /// <param name="fibo">входное число = F</param>
        /// <returns>число Фибоначчи</returns>
        static int Exercise3_1(int fibo)
        {
            if (fibo == 0 || fibo == 1)
            {
                return fibo;
            }
            if (fibo > 0)
            {
                return Exercise3_1(fibo - 1) + Exercise3_1(fibo - 2);
            }
            return 0;
        }
    }
}
