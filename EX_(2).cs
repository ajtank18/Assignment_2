using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter your number:");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = a; j >= i; j--)
                {
                    Console.Write(a+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
