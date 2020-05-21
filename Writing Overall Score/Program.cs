using System;

namespace Writing_Overall_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double task1 = Convert.ToDouble(Console.ReadLine());
            double task2 = Convert.ToDouble(Console.ReadLine());

            double result = ((task1 * 1) + (task2 * 2)) / 3;

            Console.WriteLine(((int)(result * 4 + 1) / 2) / 2.0);
        }
    }
}
