using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace grade_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Student marks");
            Console.WriteLine("------------------------------------------------------------");

            Console.Write("Subject 1:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Subject 2:");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Subject 3:");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Subject 4:");
            int a3 = int.Parse(Console.ReadLine());
            Console.Write("Subject 5:");
            int a4 = int.Parse(Console.ReadLine());
            Console.Write("Subject 6:");
            int a5 = int.Parse(Console.ReadLine());


            int total = a + a1 + a2 + a3 + a4 + a5;
            Console.WriteLine("Total Score:{0}", total);

            float avg = (a + a1 + a2 + a3 + a4 + a5) / 6;
            Console.WriteLine("Per is:{0}", avg);

            if(avg >= 35)
            {
                Console.WriteLine("First class");
            }
            else if(avg >= 51)
            {
                Console.WriteLine("Second class");
            }
            else if (avg >= 61)
            {
                Console.WriteLine("Third class");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Distinction");
            }
            else 
            { 
                Console.WriteLine("Fail"); 
            }

        }
    }
}
