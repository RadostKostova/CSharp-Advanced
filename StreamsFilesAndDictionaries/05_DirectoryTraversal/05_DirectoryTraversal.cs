using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05_DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Directory.GetCurrentDirectory();
            string[] fileNames = Directory.GetFiles(directoryPath);

            Dictionary<string, Dictionary<string, double>> filesData = new Dictionary<string, Dictionary<string, double>>();

            foreach (string fullFileName in fileNames)
            {
                FileInfo fileInfo = new FileInfo(fullFileName);
                string extension = fileInfo.Extension;
                long size = fileInfo.Length;
                double kbSize = Math.Round(size / 1024.0, 3);

                if (filesData.ContainsKey(extension) == false)
                {
                    filesData.Add(extension, new Dictionary<string, double>());
                }

                filesData[extension].Add(fileInfo.Name, kbSize);

            }

            Dictionary<string, Dictionary<string, double>> sorted = filesData
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            List<string> result = new List<string>();

            foreach (var item in sorted)
            {
                result.Add(item.Key);

                foreach (var fileData in item.Value.OrderBy(kvp => kvp.Value))
                {
                    result.Add($"--{fileData.Key} - {fileData.Value}kb");
                }
            }

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "output.txt");
            File.WriteAllLines(filePath, result);

            //successfully created a text file output.txt on the Desktop
        }
    }
}
