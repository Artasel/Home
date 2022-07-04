using System;

namespace Rab2
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
           452 -> 11
           82 -> 10
           9012 -> 12
           */
           void SumChis(int x)
           {
                int result = 0;
                int y = 0;
                string conv = Convert.ToString(x);
                x = Convert.ToInt32(conv);
                for(; y < conv.Length; y++)
                {
                    int ost = x % 10;
                    x = x / 10;
                    result += ost;
                }
                Console.WriteLine(result);
           }
           
           SumChis(123456789);
        }
    }
}
