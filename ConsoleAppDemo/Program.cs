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

            Console.ReadKey();
        }
    }
}
