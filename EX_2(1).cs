using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c , temp;
            Console.Write("enter your first letter:");
            a = Console.ReadLine();
            Console.Write("enter your secound letter:");
            b = Console.ReadLine();
            Console.Write("enter your third letter:");
            c = Console.ReadLine();
            temp = a;
            a = c;
            c = temp;
            Console.Write(a+" ");
            Console.Write(b + " ");
            Console.Write(c + " ");

        }
    }
}
