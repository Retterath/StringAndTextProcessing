using System;
using System.Collections.Generic;
using System.Linq;

namespace ShiftingCharacterPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Any text will do
            string[] words = Console.ReadLine().Split(", ").ToArray();

            Multiplier(words); // Just calling the method
            Console.WriteLine("The caesar-message has been ciphered");
            Console.WriteLine("Do you want to encrypt it?");
            string answer = Console.ReadLine();
            //StringComparison.OrdinalIgnoreCase could work on this
            if (answer == "Yes" || answer == "yes")
            {
                Console.WriteLine(string.Join("",words)); // This does put a smile on my fase
            }
        }
        public static List<char> Multiplier(string[] input)
        {
            var list = new List<char>();
            for (int i = 0; i < input.Length; i++) // Get each word seperated with this loop
            {
                string currentWord = input[i];
                char[] buffer = currentWord.ToCharArray(); // Split each word into its characters
                for (int l = 0; l < buffer.Length; l++) 
                {
                    //char letter = buffer[i];
                    char letter = buffer[l];
                    letter = (char)(letter + 3);
                    list.Add(letter);
                }
            }
            foreach (var c in list)
            {
                Console.Write(string.Join("", c));
            }
            Console.WriteLine();
            return list;
        }
        public static List<char> Devider(string[] input)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                char[] characters = word.ToCharArray();
                for (int j = 0; j < characters.Length; j++)
                {
                    char letter = characters[j];
                    letter = (char)(letter - 3);
                    list.Add(letter);
                }
            }
            foreach (var c in list)
            {
                Console.Write(string.Join("", c));
            }
            Console.WriteLine();
            return list;
        }

        
    }
}
