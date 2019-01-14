using System;

namespace gurkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            string num = "";

            Console.WriteLine("Type the first number:");
            num = Console.ReadLine();
            calc.SetFirstNumber(int.Parse(num));
            Console.WriteLine("Type the second number:");
            num = Console.ReadLine();
            calc.SetSecondNumber(int.Parse(num));
            calc.AddNumbers();
            Console.WriteLine($"The total is {calc.Result}");
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            num = Console.ReadLine();
        }
    }
}
