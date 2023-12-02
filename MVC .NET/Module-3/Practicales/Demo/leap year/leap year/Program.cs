using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year :");
            int a = int.Parse(Console.ReadLine());

            if (a%4 == 0 || a%400 == 0 || a%100 == 0)
            {
                Console.WriteLine("Leap Year");
              
            }

            else 
            { 
                Console.WriteLine("Not Leap Year"); 
            }

            Console.ReadLine();
        }
    }
}
