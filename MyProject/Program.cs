using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Checker

{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;
            while (success)
            {
                Console.WriteLine("Input Number:");
                string num1Input = Console.ReadLine();

                if (int.TryParse(num1Input, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }

                int num1 = Convert.ToInt32(num1Input);

                int num2 = 2;
                int remainder = num1 % num2;
                Console.WriteLine(remainder);

                if (remainder == 0)
                {
                    Console.WriteLine("Number is even.");
                }

                else
                {
                    Console.WriteLine("Number is odd.");
                }
            }
                //Console.ReadLine();
            }
        }
    }

