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
            int indexOfExtension = file.IndexOf('.')+1; // Same as Split('.')
            string nameOfFile = file.Substring(0,indexOfExtension -1); //Get the name without the '.', therefore "-1"
            string nameOfExtension = file.Substring(indexOfExtension); //Get the extension 
            Console.WriteLine(nameOfFile + " with extension " + nameOfExtension);
        }
    }
}
