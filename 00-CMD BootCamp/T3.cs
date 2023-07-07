using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T3_sum
{
    class T3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers to Sum.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum of two numbers is " + sum + '.');

        }
    }
}
