using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string str1 = "HELLO";
            string st = "hello";
            string st1 = "MVC";
            string str3 = "h,e,l,l,o";
            string str4 = " hello ";
            string str5 = "hello ";
            string str6 = " hello";

            Console.WriteLine("------------------------------- Upper Case -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.ToUpper());
            Console.WriteLine();

            Console.WriteLine("------------------------------- Lower Case -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str1.ToLower());
            Console.WriteLine();


            Console.WriteLine("------------------------------- Clone -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.Clone());
            Console.WriteLine();

            //Console.WriteLine("------------------------------- Copy -------------------------------");
            //Console.WriteLine();

            // Console.WriteLine(str.Copy());
            //Console.WriteLine();

            Console.WriteLine("------------------------------- Compare -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.CompareTo(st));
            Console.WriteLine();


            Console.WriteLine("------------------------------- Contains -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.Contains("h"));
            Console.WriteLine();


            Console.WriteLine("------------------------------- End With -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.EndsWith("h"));
            Console.WriteLine();


            Console.WriteLine("------------------------------- Start With -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.StartsWith("h"));
            Console.WriteLine();


            Console.WriteLine("------------------------------- Equals -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.Equals(st));
            Console.WriteLine();


            Console.WriteLine("------------------------------- Index Of -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.IndexOf("h"));
            Console.WriteLine();


            Console.WriteLine("------------------------------- Last Index Of -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.LastIndexOf("h"));
            Console.WriteLine();

            //Console.WriteLine("------------------------------- Insert -------------------------------");
            //Console.WriteLine();

            //Console.WriteLine(str.Insert(6,"st1"));
            //Console.WriteLine();

            Console.WriteLine("------------------------------- Replace -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.Replace("h", "H"));
            Console.WriteLine();


            Console.WriteLine("------------------------------- Split -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str3.Split(','));
            Console.WriteLine();


            Console.WriteLine("------------------------------- Sub String -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str.Substring(3));
            Console.WriteLine();


            Console.WriteLine("------------------------------- Trim -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str4.Trim());
            Console.WriteLine();


            Console.WriteLine("------------------------------- Trim End -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str5.TrimEnd());
            Console.WriteLine();


            Console.WriteLine("------------------------------- Trim Start -------------------------------");
            Console.WriteLine();

            Console.WriteLine(str6.TrimStart());
            Console.WriteLine();


            Console.WriteLine("------------------------------- Concat -------------------------------");
            Console.WriteLine();

            Console.WriteLine(string.Concat(str, st1));
            Console.WriteLine();



            Console.ReadLine();



        }
    }
}
