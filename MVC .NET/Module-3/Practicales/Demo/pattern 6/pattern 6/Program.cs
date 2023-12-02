using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= (a-1); j++)
                {
                    Console.Write(" ");
                }
                for (int t = 1; t < i*2; t++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
