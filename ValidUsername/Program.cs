using System;
using System.Linq;

namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            // sh, too_long_username, !lleg@l ch@rs, jeffbutt    OUTPUT	jeffbutt
            // Jeff, john45, ab, cd, peter-ivanov, @smith	OUTPUT   Jeff John45 peter-ivanov

            string[] usernames = Console.ReadLine().Split(", ").ToArray();

            for (int i = 0; i < usernames.Length; i++)
            {
                string words = usernames[i];
                bool isValid = false;
                if (words.Length >= 3 && words.Length <= 16)
                {
                    for (int k = 0; k < words.Length; k++)
                    {
                        char currentCharacter = words[k];
                        if (char.IsLetterOrDigit(currentCharacter) || currentCharacter == '-' || currentCharacter == '_' )
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(words);
                }
            }
        }
    }
}
