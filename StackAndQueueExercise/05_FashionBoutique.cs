using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allClothesInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> allClothes = new Stack<int>(allClothesInput);

            int boxCapacity = int.Parse(Console.ReadLine());
            int currRackCapacity = boxCapacity;
            int rackCounter = 1;

            while (allClothes.Any())
            {
                int clothes = allClothes.Pop();

                currRackCapacity -= clothes;

                if (currRackCapacity < 0)
                {
                    rackCounter++;
                    currRackCapacity = boxCapacity - clothes;
                }
            }

            Console.WriteLine(rackCounter);

        }
    }
}
