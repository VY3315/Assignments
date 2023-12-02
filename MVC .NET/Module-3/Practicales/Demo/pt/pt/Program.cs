using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = a; i >= 1; i--)
            {
                for (int k = i; k <= a-1; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("{0}", i);
                }
                Console.WriteLine();

            }

            for (int i = 2; i <= a; i++)
            {
                for (int k = a - 1; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", i);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
