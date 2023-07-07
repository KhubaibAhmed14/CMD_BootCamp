using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T19_number_pattern
{
    class T19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Rows");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j<=i) Console.Write(j.ToString());
                }
                Console.WriteLine("");
            }
        }
    }
}
