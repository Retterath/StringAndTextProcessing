using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // C:\Internal\training-internal\Template.pptx
            string path = Console.ReadLine();
            int startIndexOfFile = path.LastIndexOf('\\')+1; // +1 becouse we need the element after '\'
            string file = path.Substring(startIndexOfFile); // Get the 'Template.pptx' out with int
            Console.WriteLine(file);
        }
    }
}
