using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assi_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string n1 = Console.ReadLine();
            int num1 = int.Parse(n1);
            Console.WriteLine("Enter second number: ");
            string n2 = Console.ReadLine();
            int num2 = int.Parse(n2);
            Console.WriteLine("Enter operation +,-,*,/");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    if (num2!=0){
                        Console.WriteLine(num1 / num2);
                    }
                    else{
                        Console.WriteLine("Cannot divide by zero");
                    }
                    
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
