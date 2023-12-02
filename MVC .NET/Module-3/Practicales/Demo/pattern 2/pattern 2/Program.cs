using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = a; i >= 1; i--) 
            {
                for (int j = i; j >= 1; j--) 
                {
                    Console.Write("{0}",i); 
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
