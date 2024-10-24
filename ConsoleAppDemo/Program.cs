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

            double result3 = calculate.Mnozenie(3, 2);
            Console.WriteLine($"Rezultat mnozenie: {result3}");

            Console.ReadKey();
        }
    }
}
