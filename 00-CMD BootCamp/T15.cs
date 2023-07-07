using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T15_pattern
{
    class T15

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Rows");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j=1;j<= n + i*2; j++)
                {
                    if (j <= n - i || j >= n + i) Console.Write(" ");
                    else Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
