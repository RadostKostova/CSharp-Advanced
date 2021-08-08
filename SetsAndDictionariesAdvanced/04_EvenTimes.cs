using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 0);
                }

                dict[number]++;
            }

            KeyValuePair<int, int> kvp = dict.First(kvp => kvp.Value % 2 == 0);
            Console.WriteLine(kvp.Key);
        }
    }
}
