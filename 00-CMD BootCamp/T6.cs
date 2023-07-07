using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T6_sum_upto_n
{
    class T6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Sum upto.");
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=0;i<=num1;i++) { sum += i; }
            Console.WriteLine("The sum of numbers upto " + num1 + " is " + sum + '.');
        }
    }
}
