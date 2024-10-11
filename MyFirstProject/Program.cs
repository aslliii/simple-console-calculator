using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation Programm");
            double result = 0;

            Console.WriteLine("Write your first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write your second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. + : Addition");
            Console.WriteLine("2. - : Subtraction");
            Console.WriteLine("3. * : Multiplication");
            Console.WriteLine("4. / : Devide");

            switch (Console.ReadLine())
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                    break;

                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                    break;

                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                    break;

                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: My dear, I love you, but division by zero is not allowed, sorry.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {result}");
                    }
                    break;

                default:
                    Console.WriteLine("That was not a valid operation. Please enter numeric values");
                    break;

            }
            Console.ReadLine();

        }
    }
}





