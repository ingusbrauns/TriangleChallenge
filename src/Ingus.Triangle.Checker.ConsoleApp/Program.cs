using System;

namespace Ingus.Triangle.Checker.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lengths of a triagles three sides: A, B and C");
            var a = Prompt("A: ");
            var b = Prompt("B: ");
            var c = Prompt("C: ");
            var type = TypeChecker.GetTriangleType(a, b, c);
            switch (type)
            {
                case TriangleType.Equilateral:
                case TriangleType.Isoseles:
                case TriangleType.Scalene:
                    Console.WriteLine($"The triangle is {type.ToString().ToLower()}.");
                    break;
                case TriangleType.None:
                    Console.WriteLine($"The given lengths do not form a triangle.");
                    break;
                default:
                    break;
            }

            Console.Write("press any key to close");
            Console.ReadKey();
        }

        private static double Prompt(string promptMessage)
        {
            while (true)
            {
                Console.Write(promptMessage);
                if (double.TryParse(Console.ReadLine(), out double length))
                {
                    if (Validate(length))
                    {
                        return length;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a length above 0!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
            }
        }

        private static bool Validate(double length)
        {
            return length > 0;
        }
    }
}
