using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i += 1)
            {
                int r = i % 2;
                if (r == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
