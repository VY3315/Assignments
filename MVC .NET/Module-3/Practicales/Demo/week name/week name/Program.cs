﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter week day number : ");
            int a= int .Parse(Console.ReadLine());
            
            switch (a) 
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default: Console.WriteLine("Pls enter 1 to 7 only"); break;
            }
            Console.ReadLine();
        }
    }
}
