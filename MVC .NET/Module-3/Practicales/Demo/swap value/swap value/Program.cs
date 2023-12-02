using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Value of A :");  // a=10
            int a=int.Parse(Console.ReadLine());
            Console.Write("Value of B:");   // b=20
            int b=int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Swap value of A is {0} and b is {1}", a, b);

        }
    }
}
