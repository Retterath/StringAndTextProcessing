using System;
using System.Linq;

namespace CharacterMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            // a aaaa
            // 123 532
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            string longerWord = "";
            string shorterWord = "";

            int end = 0;
            if (firstWord.Length >= secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }
            end = Multiplier(longerWord, shorterWord);
            Console.WriteLine(end);
        }
        public static int Multiplier(string word1, string word2)
        {
            int result = 0;
            for (int i = 0; i < word2.Length; i++) //Get all characters multiplied if they are even
            {
                result += word1[i] * word2[i];
                if (word1.Length > word2.Length) //Break if they arent even anymore
                {
                    break;
                }
            }
            for (int i = word2.Length; i < word1.Length; i++) // Add all remaining characters if they arent even
            {
                result += word1[i]; //Adding
            }
            return result;
        }
    }
}
