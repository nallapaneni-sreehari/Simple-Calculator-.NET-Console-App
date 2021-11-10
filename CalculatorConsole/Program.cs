using System;
using CalculationsLibrary;

namespace CalculatorConsole
{
    class Program
    {
        static void Main()
        {
            string proceed = "y";
            while (proceed.ToLower() == "y")
            {
                Console.WriteLine("-----------Options-------------");
                Console.WriteLine("1.Add\n2.subtract\n3.multiply\n4.divide");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Enter Choices:: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch <= 0 || ch > 4)
                {
                    Console.WriteLine("Invalid Options");
                    proceed = "n";
                }
                else
                {
                    Console.WriteLine("Enter 1st Number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd Number: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {

                        case 1:
                            Console.WriteLine($"Addition of {a}, {b} is {CalculationsLibrary.Calculator.Add(a, b)}");
                            break;
                        case 2:
                            Console.WriteLine($"Subtraction of {a}, {b} is {CalculationsLibrary.Calculator.Subtract(a, b)}");
                            break;
                        case 3:
                            Console.WriteLine($"Multiplication of {a}, {b} is {CalculationsLibrary.Calculator.Multiply(a, b)}");
                            break;
                        case 4:
                            Console.WriteLine($"Division of {a}, {b} is {CalculationsLibrary.Calculator.Divide(a, b)}");
                            break;
                    }
                    Console.WriteLine("would you like to continue[y/n/Y/N]:---");
                    proceed = Console.ReadLine();
                }
            }
        }
    }
}
