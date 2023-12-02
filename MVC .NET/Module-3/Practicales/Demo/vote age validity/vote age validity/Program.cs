using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vote_age_validity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter you age");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Age:");
            int a=int .Parse(Console.ReadLine());
            if (a>=18)
            {
                Console.WriteLine("you are eligible for votting");
            }
            else
            {
                Console.WriteLine("you are not eligible for votting");

            }

        }
    }
}
