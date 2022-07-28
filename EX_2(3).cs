using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            char s;
            Console.Write("Enter your value:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter your opration:");
            s = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter your value:");
            b = int.Parse(Console.ReadLine());
            if (s == '+')
            {
                c = a + b;
                Console.Write(a+" " + "+" +" "+ b+" " + "="+" " + c);
            }
            else if (s == '-')
            {
                c = a - b;
                Console.Write(a + " " + "-" + " " + b + " " + "=" + " " + c);
            }
            else if (s == '*')
            {
                c = a * b;
                Console.Write(a + " " + "*" + " " + b + " " + "=" + " " + c);
            }
            else if (s == '/')
            {
                c = a * b;
                Console.Write(a + " " + "/" + " " + b + " " + "=" + " " + c);
            }
            else
            {
                Console.WriteLine("enter valid operation");
            }
           
        }
    }
}
