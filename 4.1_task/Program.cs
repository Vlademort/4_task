using System;

namespace _4._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число больше нуля");
            int N = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
           
            if (N < 0)
            {
                Console.WriteLine("Ошибка!");
            }
            else
            {
                for (int i = 1; i <= N; i ++)
                {
                    Sum += 2 * i - 1;
                    Console.WriteLine("Сумма равна {0} ", Sum);
                }
                Console.ReadKey();
            }
        }
    }
}
