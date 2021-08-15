using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01_EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine("..", "..", "..", "text.txt");
            string pattern = @"[-,.!?]";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                int counter = 0;

                while (line != null)
                {
                    if (counter++ % 2 == 0)
                    {
                        string replacedLine = Regex.Replace(line, pattern, "@");

                        string[] words = replacedLine.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);                    
                        Console.WriteLine(string.Join(" ", words.Reverse()));
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
