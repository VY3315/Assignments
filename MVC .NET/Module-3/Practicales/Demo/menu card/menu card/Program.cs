
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_card
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\t MENU");
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("Press I for Italian");
            Console.WriteLine("Press C for Chinese");
            Console.WriteLine("Press P for Punjabi");
            Console.WriteLine("Press S for South Indian");

            Console.WriteLine("---------------------------------------------------------------------------------------------");


            Console.WriteLine("Pls enter : ");
            char a = char.Parse(Console.ReadLine());

            switch (a) 
            {
               case 'i':
                    Console.WriteLine("Italial");
                    break;

                case 'c':
                    Console.WriteLine("Chinese");
                    break;

                case 'p':
                    Console.WriteLine("Punjabi");
                    break;

                case 's':
                    Console.WriteLine("South Indian");
                    break;

                case 'I':
                    Console.WriteLine("Italian");
                    break;

                case 'C':
                    Console.WriteLine("Chinese");
                    break;

                case 'P':
                    Console.WriteLine("Punjabi");
                    break;

                case 'S':
                    Console.WriteLine("South Indian");
                    break;

                default: Console.WriteLine("Pls enter from given menu items");break;   
            }
            Console.ReadLine();
        }
    }
}
