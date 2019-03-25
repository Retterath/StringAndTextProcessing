using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            
            while (line != "end")
            {
                line = Console.ReadLine();
               
            }
            string reversed = "";
            for (int i = line.Length - 1; i >= 0; i--)
            {
                reversed += line[i];
            }
            foreach (var item in reversed)
            {
                Console.WriteLine($"{line} => {reversed}");
            }


        }
    }
}
