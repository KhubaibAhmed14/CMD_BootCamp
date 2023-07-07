using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T9_factorial
{
    class T9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to take it's factorial");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i=1; i<=num; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);

        }
    }
}
