﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Tips
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.07;
            const double TIP_RATE_LESS = 0.1;
            const double TIP_RATE_MORE = 0.2;
            double subTotal = Math.Round(userInput(), 2);
            double tax = Math.Round(subTotal * TAX_RATE, 2);
            double total = subTotal + tax;
            double tipLess = Math.Round(total * TIP_RATE_LESS, 2);
            double tipMore = Math.Round(total * TIP_RATE_MORE, 2);
            double totalLess = total + tipLess;
            double totalMore = total + tipMore;

            Console.WriteLine($"Subtotal: ${subTotal}");
            Console.WriteLine($"Tax rate:  {TAX_RATE*100}%");
            Console.WriteLine($"Total:    ${total}");
            Console.WriteLine($"Tip(10%): ${tipLess}");
            Console.WriteLine($"Total:    ${totalLess}");
            Console.WriteLine($"Tip(20%): ${tipMore}");
            Console.WriteLine($"Total:    ${totalMore}");
            Console.ReadKey();
        }
        static double userInput()
        {
            string input;
            double check;
            while (true)
            {
                Console.Write("Please enter your restaurant charge:");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Empty input");
                    continue;
                }
                else if(!double.TryParse(input, out check))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                else if (check < 0)
                {
                    Console.WriteLine("Negative value");
                    continue;
                }
                else if (check < 10)
                {
                    Console.WriteLine("Minimum $10");
                    continue;
                }
                else
                    return check;
            }
        }
    }
}
