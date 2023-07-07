using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T10_fibonacci
{
    class T10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to calculate Fibonacci sequence:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++) { Console.Write(Fibonacci(i) + " "); }
            
        }

        static int Fibonacci(int num)
        {
            if (num <= 1) { return num; }
            else { return Fibonacci(num - 1) + Fibonacci(num - 2); }


            // NON RECURSIVE APPROACH
            //if (num <= 1) { return num;}
            //int previous = 0;
            //int current = 1;
            //int result = 0;

            //for (int i = 2; i <= num; i++)
            //{
            //    result = previous + current;
            //    previous = current;
            //    current = result;
            //}
            //return result;
        }
    }
}
