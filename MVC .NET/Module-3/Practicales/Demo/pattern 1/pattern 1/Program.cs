﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}",j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();    
        }
    }
}
