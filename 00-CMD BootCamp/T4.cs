using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T4_suare
{
    class T4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Numbers to Square.");
            int num1 = int.Parse(Console.ReadLine());
            double square = Math.Pow(num1, 2);
            Console.WriteLine("The sum of two numbers is " + square + '.');
        }
    }
}
