using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T14_right_angle_triangle
{
    class T14

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Height of the Triangle");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width of the Triangle(No of *'s to add per Row)");
            int w = int.Parse(Console.ReadLine());

            for (int i=0;i<h;i++)
            {
                for (int j = h - i; j <= w; j++) Console.Write("*");
                Console.WriteLine("");
            }
            
        }
    }
}
