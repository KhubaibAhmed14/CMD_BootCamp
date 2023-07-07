using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T8_prime_nums
{
    class T8
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a Numbers to print Prime Numbers upto.");
            int num = int.Parse(Console.ReadLine());

            List<int> prime_lst = new List<int>() { 2, 3 };
            for (int i = 4; i <= num; i++)
            {
                for (int j = 0; j <= prime_lst.Count; j++)
                {
                    if (i % prime_lst[j] == 0) { break; }
                    if (i % prime_lst[j] != 0 & j == prime_lst.Count-1)
                    {
                        prime_lst.Add(i);
                    }
                }
            }

            foreach (int prime in prime_lst) { Console.WriteLine(prime); }

            //for (int i = 2; i <= num; i++)
            //{
            //    int c = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            c++;
            //            if (c > 3) { break; }
            //        }
            //    }
            //    if (c == 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}
