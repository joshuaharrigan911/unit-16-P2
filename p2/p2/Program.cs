using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo status;
            float answer;

            while (true)
            {
                Console.Write("Please enter the first integer: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {//if "-" is selected the calculation will be subtracted 
                    case "-":
                        answer = num1 - num2;
                        break;
                 // if "+" is selected the calculation will be addition 
                    case "+":
                        answer = num1 + num2;
                        break;
                 // if "/" is selected the calculation will be division 
                    case "/":
                        answer = num1 / num2;
                        break;
                 // if "*" is selected the calculation will be multiplication 
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
                Console.WriteLine("\n\n Do You Want To Break (Y/y)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();

            }
        }
    }
}
