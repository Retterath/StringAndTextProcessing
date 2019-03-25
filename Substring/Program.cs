using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            
            for (int i = 1; i < secondLine.Length; i++)
            {
                secondLine = secondLine.Remove(firstLine)
                secondLine.Remove(i, appearance);
            }
                
            Console.WriteLine(secondLine);
        }
    }
}
