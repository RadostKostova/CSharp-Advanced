using System;
using System.Linq;
using System.Collections.Generic;

namespace _05_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> occurancies = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (occurancies.ContainsKey(input[i]) == false)
                {
                    occurancies.Add(input[i], 1);
                }
                else
                {
                    occurancies[input[i]]++;
                }
            }

            foreach (var item in occurancies)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
