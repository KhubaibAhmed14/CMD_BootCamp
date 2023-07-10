using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    internal class Program
    {
        static string[] Preprocess(string sentence)
        {
            sentence = new string(sentence.Where(word => !Char.IsPunctuation(word)).ToArray());
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-clause
            // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-7.0
            return sentence.Split(' ');
                }
        static void PrintIntroMessage()
        {
            Console.WriteLine("\n\nPlease Enter the type of Analysis You want to perform on the text.\n\n" +
                "Press 1 : For WORD FREQUENCY ANALYSIS\n" +
                "Press 2 : For SENTENCE MAKER\n" +
                "Press 3 : For LONGEST and SHORTEST WORD FINDER\n" +
                "Press 4 : For WORD SEARCH\n" +
                "Press 5 : For PALINDROME DETECTOR\n" +
                "Press 6 : For VOWEL and CONSONANT COUNTER\n\n" +
                "Press Q : For TO QUIT");
        }
        static void FreqAna(string[] sentence)
        {
            Dictionary<string,int> freqDic = new Dictionary<string,int>();
            foreach (string word in sentence)
            {
                if (freqDic.ContainsKey(word)) freqDic[word]++;
                else freqDic[word]  =1;
            }

            Console.WriteLine("\nWord Frequecy");
            foreach (KeyValuePair<string,int> pair in freqDic)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
        }
        static void SMaker(string[] sentence) {
            Console.WriteLine("\nSentence Maker.");
            Console.WriteLine("\nEnter the Number of Sentences to Generrate.");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(sentence[rnd.Next(sentence.Length)] + " ");
                }
                Console.WriteLine();
            }
        }
        static void LSFinder(string[] sentence) {
            Console.WriteLine("\nLongest and Shortest Word Finder.");
            List<string> lWord = new List<string>();
            List<string> sWord = new List<string>();
            int maxLengnth = 0;
            int minLenght = int.MaxValue;
            foreach (string word in sentence)
            {
                if (word.Length > maxLengnth)
                {
                    maxLengnth = word.Length;
                    lWord.Clear();
                    lWord.Add(word);
                }
                else if (word.Length == maxLengnth) { 
                    lWord.Add(word);
                }

                if (word.Length < minLenght)
                {
                    minLenght = word.Length;
                    sWord.Clear();
                    sWord.Add(word);
                }
                else if (word.Length == minLenght)
                {
                    sWord.Add(word);
                }
            }

            Console.WriteLine("\nLongest Words");
            foreach (string word in lWord)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\nShortest Words");
            foreach (string word in sWord)
            {
                Console.WriteLine(word);
            }



        }
        static void WordSearch(string[] sentence) {
            Console.WriteLine("\nWord Search");
            Console.WriteLine("\nEnter word to searh");
            string word = (Console.ReadLine().ToLower());
            int counter = 0;
            foreach (string str in sentence) {
                if (str == word) counter++;
            }
            if (counter == 0) Console.WriteLine("The word " + word + " was not Found.");
            else Console.WriteLine("The word " + word + " appears {0, 2} times.", counter);
        }
        static void Palindrome(string[] sentence) {
            Console.WriteLine("\nPalindrome Detector");
            List<string> pList = new List<string>();
            foreach(string word in sentence)
            {
                bool state = true;
                for (int i = 0; i <= Convert.ToInt32((word.Length - 1) / 2); i++)
                {
                    int j = word.Length - 1 - i;
                    if (word[i] != word[j]) { state = false; break; }
                }
                if (state) {
                    pList.Add(word);
                }
            }
            if (pList.Count == 0) Console.WriteLine("\nThere are no Palindromic words in the sentence.");
            foreach(string word in pList) Console.WriteLine(word);
        }
        static void VCCounter(string[] sentence) {
            bool IsVowel(char c)
            {
                return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            }
            int counter = 0;
            foreach (string word in sentence)
            {
                foreach (char c in word)
                {
                    if (IsVowel(c)) counter++;
                }
                Console.WriteLine("{0,10} : {1,2} vowels and {2,2} consonants.", word, counter, (word.Length - counter));
                counter = 0;
            }
        }  

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This is Text Analyzer.");
            Console.WriteLine("Please Enter the Sentence for Analysis.");
            string sentence = (Console.ReadLine()).ToLower();
            string[] sentenceArr = Preprocess(sentence);

            while (true)
            {
                PrintIntroMessage();
                string input = Console.ReadLine();
                if (input == "1") FreqAna(sentenceArr);
                else if (input == "2") SMaker(sentenceArr);
                else if (input == "3") LSFinder(sentenceArr);
                else if (input == "4") WordSearch(sentenceArr);
                else if (input == "5")Palindrome(sentenceArr);
                else if (input == "6") VCCounter(sentenceArr);
                else if (input == "q" || input == "Q") break;
                else { Console.WriteLine("Wrong Prompt."); }
            }
        }
    }
}
