//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A1_S3
//{
//    internal class T12
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the word");
//            string word = Console.ReadLine();
//            bool state=true;
//            for (int i= 0; i <= Convert.ToInt32((word.Length-1)/2); i++){
//                int j = word.Length - 1 - i;
//                if (word[i] != word[j]) { state = false; break; }
//                //else j--;
//            }
//            if (state) { Console.WriteLine(word + " is a Palindrome."); }
//            else { Console.WriteLine(word + " is a not Palindrome"); }
//        }
//    }
//}
