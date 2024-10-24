using ConsoleAppDemo.Serives;
using System;

namespace ConsoleAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            double result1 = calculate.Dodawanie(1, 3);
            Console.WriteLine($"Rezultat dodawania: {result1}");

            double result2 = calculate.Odejmowanie(10, 3);
            Console.WriteLine($"Rezultat odejmow3anie: {result2}");

            Console.ReadKey();
        }
    }
}
