using System;

namespace Rab3
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
           1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
           6, 1, 33 -> [6, 1, 33]
           */
           void InitAndWiwod(int size)
           {
                int[] Array = new int[size];
                int x = 0;
                for(; x < size; x++)
                {
                    Array[x] = new Random().Next(101);
                }
                Console.Write($"[{String.Join(", ", Array)}]");
           }
                InitAndWiwod(8);
        }
    }
}
