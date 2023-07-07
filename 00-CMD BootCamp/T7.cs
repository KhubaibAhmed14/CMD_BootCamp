using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T7_table_12
{
    class T7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine(i + " multiplied by " + j + " equals to " + i * j);
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
