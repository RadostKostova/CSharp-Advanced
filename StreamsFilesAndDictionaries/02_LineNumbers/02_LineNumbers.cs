using System;
using System.Collections.Generic;
using System.IO;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFilePath = Path.Combine("..", "..", "..", "output.txt");
            string[] lines = File.ReadAllLines("text.txt");
            List<char> punctuationMarks = new List<char>() { '-', ',', '.', '!', '?', '\'' };

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int lettersCount = 0;
                int punctuationMarksCount = 0;

                foreach  (char ch in line)
                {
                    if (char.IsLetter(ch))
                    {
                        lettersCount++;
                    }
                    else if (char.IsPunctuation(ch))
                    {
                        punctuationMarksCount++;
                    }
                }

                string newLine = $"Line {i + 1}:{line} ({lettersCount})({punctuationMarksCount})";
                Console.WriteLine(newLine);
                File.AppendAllText(outputFilePath, newLine + Environment.NewLine);
            }
        }
    }
}
