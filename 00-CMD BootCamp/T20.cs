using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_T20_longest_sub_sequence
{
    class T20

    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the First Sequence");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Enter the Second Sequence");
            //string s2 = Console.ReadLine();

            string s1 = "RSASARFT";
            string s2 = "SASARGT";


            //string sub_seq = "";
            //int temp = 0;
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    for (int j = 0; j < s2.Length - temp; j++)
            //    {
            //        if (s1[i] == s2[j + temp]) { sub_seq += s1[i]; temp = j; break; }
            //    }

            //}
            //Console.WriteLine("The longest subsequence is " + sub_seq);

            int m = s1.Length;
            int n = s2.Length;
            LCS(s1, s2, m, n);
        }


        static void LCS(String x, String y, int m, int n)
        {
            int[,] subSeq_arr = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        subSeq_arr[i, j] = 0;
                    else if (x[i - 1] == y[j - 1])
                        subSeq_arr[i, j] = subSeq_arr[i - 1, j - 1] + 1;
                    else
                        subSeq_arr[i, j] = Math.Max(subSeq_arr[i - 1, j],
                                           subSeq_arr[i, j - 1]);
                }
            }

            // Following code is used to print LCS
            int index = subSeq_arr[m, n];
            int temp = index;

            char[] lcs = new char[index + 1];
            lcs[index] = '\0';

            int k = m, l = n;
            while (k > 0 && l > 0)
            {
                if (x[k - 1] == y[l - 1])
                {
                    lcs[index - 1] = x[k - 1];
                    k--;
                    l--;
                    index--;
                }

                else if (subSeq_arr[k - 1, l] > subSeq_arr[k, l - 1])
                    k--;
                else
                    l--;
            }

            Console.Write("LCS of " + x + " and " + y + " is ");
            for (int q = 0; q <= temp; q++)
                Console.Write(lcs[q]);
        }
    }
}
