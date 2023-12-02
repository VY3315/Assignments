using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Value of A:");
            int a= int.Parse(Console.ReadLine());

            Console.Write("Value of B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Adiition is : {0}",a+b);
            Console.WriteLine("Substraction is : {0}",a-b);
            Console.WriteLine("Division is : {0}", a / b);
            Console.WriteLine("Multipication is : {0}", a * b);
            Console.WriteLine("Modulus is : {0}", a % b);



            Console.ReadLine();
        }
    }
}
