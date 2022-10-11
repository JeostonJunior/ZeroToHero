using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main (string[] args)
        {
            string sourcePath = @"c:\Users\jeoston.araujo\Documents\ZeroToHero\TrabalhandoComArquivos\text1.txt";
            string targetPath = @"c:\Users\jeoston.araujo\Documents\ZeroToHero\TrabalhandoComArquivos\text3.txt";

            try
            {
                //FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                //File.WriteAllLines(targetPath, File.ReadAllLines(sourcePath));
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    File.WriteAllText(targetPath, line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");

            }


        }
    }
}
