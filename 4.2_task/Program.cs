using System;

namespace _4._2_task
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int count_positive = 0;
                int count_negative = 0;
                int N = 0;
                do
                {
                    Console.Write("Введите число: ");
                    N = Convert.ToInt32(Console.ReadLine());                   
                    count_positive = (N > 0) ? count_positive + 1 : count_positive;
                    count_negative = (N < 0) ? count_negative + 1 : count_negative;
                }
                while (N != 0);

                if (count_positive == count_negative)
                {
                    Console.WriteLine("Одинаковое количество положительных и отрицательных чисел");
                    Console.ReadKey();
                }
                else if (count_positive > count_negative)
                {
                    Console.WriteLine("Положительных чисел больше и равно {0}", count_positive);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Отрицательных чисел больше и равно {0}", count_negative);
                    Console.ReadKey();
                }

            }


        }

    }
}
