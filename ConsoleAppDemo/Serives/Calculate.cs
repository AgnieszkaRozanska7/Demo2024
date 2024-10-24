using ConsoleAppDemo.Serives.Interfaces;

namespace ConsoleAppDemo.Serives
{
    public class Calculate : ICalculate
    {
        public double Dodawanie(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
