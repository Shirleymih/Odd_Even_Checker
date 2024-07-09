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

                try
                {
                    Console.Write("Input Number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num1);

                    
                    int num2 = 2;
                    int remainder = num1 % num2;
                    success = false;

                    if (remainder == 0)
                    {
                        Console.WriteLine("Number is even.");
                    }

                    else
                    {
                        Console.WriteLine("Number is odd.");
                    }
                }

                catch (OverflowException)
                {
                    Console.WriteLine("Please, only enter a number less than 2 billion!");
                  
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, only enter numbers!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to convert!");
                }

            }
            Console.ReadLine();
        }
    }
}

