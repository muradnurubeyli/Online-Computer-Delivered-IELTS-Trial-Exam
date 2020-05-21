// Authors of formula: Barish Namazov & Murad Nurubeyli
using System;

namespace Score_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double listening = Convert.ToDouble(Console.ReadLine());
            double reading = Convert.ToDouble(Console.ReadLine());
            double writing = Convert.ToDouble(Console.ReadLine());
            double speaking = Convert.ToDouble(Console.ReadLine());

            double average = (listening + reading + writing + speaking) / 4;
            Console.WriteLine(((int)(average * 4 + 1) / 2) / 2.0);

        }
    }
}
