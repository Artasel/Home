using System;

namespace Rab1
{
    class Program
    {
        static void Main(string[] args)
        {
          /*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
          3, 5 -> 243 (3⁵)
          2, 4 -> 16
          */
            void WoswedWStep(int A, int B)
            {
                int Result = A;
                int a = 1;
                for(; a < B; a++)
                {
                    Result *= A; 
                }
                Console.WriteLine(Result);
            }

            WoswedWStep(3, 5);
        }
    }
}
