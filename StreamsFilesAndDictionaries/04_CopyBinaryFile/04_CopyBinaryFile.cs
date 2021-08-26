using System;
using System.IO;

namespace _04_CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream readStream = new FileStream("copyMe.png", FileMode.Open);
            using FileStream writeStream = new FileStream("newImage.png", FileMode.Create);

            while (readStream.Position < readStream.Length)
            {
                byte[] buffer = new byte[4096];
                int count = readStream.Read(buffer, 0, buffer.Length);
                
                writeStream.Write(buffer);
            }
        }
    }
}
