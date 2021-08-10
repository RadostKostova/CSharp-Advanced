using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = cmdArgs[0];
                string[] allClothing = cmdArgs.Skip(1).ToArray();

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> currColorClothing = wardrobe[color];

                foreach (string item in allClothing)
                {
                    if (!currColorClothing.ContainsKey(item))
                    {
                        currColorClothing.Add(item, 0);
                    }
                    currColorClothing[item]++;
                }
            }
            string[] searchData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach ((string color, Dictionary<string,int> colorData) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach ((string clothing, int count) in colorData)
                {
                    if (searchData[0] == color && searchData[1] == clothing)
                    {
                        Console.WriteLine($"* {clothing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing} - {count}");
                    }
                }
            }
        }
    }
}
