using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int k = a-1; k >= i; k--)
                {
                    //Console.Write(" ");
                }
                for (int j = i; j <= a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= a; i++)
            {
                for (int k = a - 1; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
