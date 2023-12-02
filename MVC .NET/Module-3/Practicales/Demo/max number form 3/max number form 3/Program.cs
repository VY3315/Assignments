using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_number_form_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of A : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of B : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of C : ");
            int c = int.Parse(Console.ReadLine());

            //a>b,c a max
            //b>c,a b max
            //ot c max
            
            if (a > b)
            {

                if (b > c)
                {
                    Console.WriteLine("B is Max");
                }
                else
                {
                    Console.WriteLine("C is Max");
                }
                Console.WriteLine("A is max");

            }
            else { Console.WriteLine("C is Max"); }
            Console.ReadLine();
        }
    }
}
