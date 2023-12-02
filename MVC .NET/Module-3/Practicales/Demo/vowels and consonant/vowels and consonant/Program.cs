using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels_and_consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character : ");
            char a = char.Parse(Console.ReadLine());

            switch (a) 
            { 
                case 'a':
                    Console.WriteLine("Vowels");
                    break;

                case 'e':
                    Console.WriteLine("Vowels");
                    break;

                case 'i':
                    Console.WriteLine("Vowels");
                    break;

                case 'o':
                    Console.WriteLine("Vowels");
                    break;

                case 'u':
                    Console.WriteLine("Vowels");
                    break;

                case 'A':
                    Console.WriteLine("Vowels");
                    break;

                case 'E':
                    Console.WriteLine("Vowels");
                    break;

                case 'I':
                    Console.WriteLine("Vowels");
                    break;

                case 'O':
                    Console.WriteLine("Vowels");
                    break;

                case 'U':
                    Console.WriteLine("Vowels");
                    break;

                    default: 
                    Console.WriteLine("Consenant");
                    break;
            }

            Console.ReadLine();
        }
    }
}
