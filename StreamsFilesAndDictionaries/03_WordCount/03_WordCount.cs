using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string expextedResultPath = Path.Combine("..", "..", "..", "expectedResult.txt");
            string actualResultPath = Path.Combine("..", "..", "..", "actualResult.txt");

            string[] words = File.ReadAllLines("words.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordsCount.Add(word.ToLower(), 0);
            }

            string text = File.ReadAllText("text.txt").ToLower();
            string[] textWords = text.Split(new string[] { " ", ",", ".", "!", "?", "-", Environment.NewLine }, 
                StringSplitOptions.RemoveEmptyEntries );

            foreach (string word in textWords)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            List<string> actualOutputLines = wordsCount
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToList();
            
            File.WriteAllLines(actualResultPath, actualOutputLines);

            Dictionary<string, int> sorted = wordsCount
                .OrderByDescending(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            List<string> expectedOutputLines = sorted
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToList();

            File.WriteAllLines(expextedResultPath, expectedOutputLines);
        }
    }
}
