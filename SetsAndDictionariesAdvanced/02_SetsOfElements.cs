using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizesOfTwoSets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < sizesOfTwoSets[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < sizesOfTwoSets[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }


            foreach (var firstElement in firstSet)
            {
                foreach (var secondElement in secondSet)
                {
                    if (firstElement == secondElement)
                    {
                        Console.Write(secondElement + " ");
                    }
                }
            }
        }
    }
}
