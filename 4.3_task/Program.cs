using System;

namespace _4._3_task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите длину прямоугольника A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону квадрата C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            int count_square = 0;
            int A1 = A;
            int A2 = A;
            int B1 = B;
            int B2 = B;

            if (A < C && B < C)
            {
                Console.WriteLine("Не возможно разместить квадраты на прямоугольнике AxB");
                Console.ReadKey();
            }
            else
            {
                while (A1 >= C)
                {
                    count_square++;
                    A1 -= C;
                }
                while (B1 >= C)
                {
                    count_square++;
                    B1 -= C;
                }
                while (A2 >= C)
                {
                    count_square++;
                    A2 -= C;
                }
                while (B2 >= C)
                {
                    count_square++;
                    B2 -= C;
                }
                Console.WriteLine("Количество квадратов равно {0}", count_square);
                Console.ReadKey();
            }                         
            
            
        }
    }
}
