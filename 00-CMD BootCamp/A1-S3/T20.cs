//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A1_S3
//{
//    internal class T20
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the First Sequence");
//            string s1 = Console.ReadLine();
//            Console.WriteLine("Enter the Second Sequence");
//            string s2 = Console.ReadLine();

//            string s1 = "RSASARFT";
//            string s2 = "SASARGT";


//            string sub_seq = "";
//            int temp = 0;
//            for (int i = 0; i < s1.Length; i++)
//            {
//                for (int j = 0; j < s2.Length - temp; j++)
//                {
//                    if (s1[i] == s2[j + temp]) { sub_seq += s1[i]; temp = j; break; }
//                }

//            }
//            Console.WriteLine("The longest subsequence is " + sub_seq);
//        }
//    }
//}

using System;

class Program
{
    static void Main()
    {
        string str1 = "RSASARFT";
        string str2 = "SASARGT";

        string longestSubsequence = LongestCommonSubsequence(str1, str2);

        Console.WriteLine("Longest Common Subsequence: " + longestSubsequence);
    }

    static string LongestCommonSubsequence(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            {
                if (i == 0 || j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        int length = dp[m, n];
        char[] longestSubsequenceArray = new char[length];
        int index = length - 1;
        int x = m;
        int y = n;

        while (x > 0 && y > 0)
        {
            if (str1[x - 1] == str2[y - 1])
            {
                longestSubsequenceArray[index] = str1[x - 1];
                index--;
                x--;
                y--;
            }
            else if (dp[x - 1, y] > dp[x, y - 1])
            {
                x--;
            }
            else
            {
                y--;
            }
        }

        return new string(longestSubsequenceArray);
    }
}

