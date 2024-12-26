using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_q3
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

            int choice;
            do
            {
                Console.WriteLine("Enter  0 for Exit");
                Console.WriteLine("Enter  1 for Addition");
                Console.WriteLine("Enter  2 for Subtraction");
                Console.WriteLine("Enter  3 for Multiplication");
                Console.WriteLine("Enter  4 for Division");
                string operation = Console.ReadLine();
                choice = int.Parse(operation);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine(num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine(num1 * num2);
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine(num1 / num2);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (choice!=0);
        }
    }
}
