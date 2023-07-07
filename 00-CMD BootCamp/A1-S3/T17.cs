//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A1_S3
//{
//    internal class T17
//    {
//        static void Main(string[] args)
//        {
//            int[] array = { 3, 4, 1, 2, 5, 6, 7, 8, -14, 65, 5 };
//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = i + 1; j < array.Length; j++)
//                {
//                    if (array[j] < array[i])
//                    {
//                        int temp = array[j];
//                        array[j] = array[i];
//                        array[i] = temp;
//                        //if (j == array.Length - 1) i++;
//                    }
//                }
//            }

//            foreach (int num in array) { Console.Write(num + "\t"); }


//        }
//    }
//}
