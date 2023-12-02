using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of A : "); //10
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of B : "); //11
            int b=int.Parse(Console.ReadLine());

            if(a<b)
            {
                Console.WriteLine("B is max ");
            }
            else if(b<a)
            {
                Console.WriteLine("A is max");
            }
            else { Console.WriteLine("Both are Equal"); }
        }
    }
}
