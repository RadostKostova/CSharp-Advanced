using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            SortedSet<string> chemicals = new SortedSet<string>();

            while (countLines-- > 0)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                foreach (var item in cmdArgs)
                {
                    chemicals.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", chemicals));
        }
    }
}
