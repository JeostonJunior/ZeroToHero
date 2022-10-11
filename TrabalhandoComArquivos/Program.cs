using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main (string[] args)
        {
            string sourcePath = @"c:\Users\jeoston.araujo\Documents\ZeroToHero\TrabalhandoComArquivos\text1.txt";
            //string targetPath = @"c:\Users\jeoston.araujo\Documents\ZeroToHero\TrabalhandoComArquivos\text3.txt";
            FileStream fs = null;
            StreamReader sr = null;


            try
            {
                ////FileInfo fileInfo = new FileInfo(sourcePath);
                ////fileInfo.CopyTo(targetPath);
                ////File.WriteAllLines(targetPath, File.ReadAllLines(sourcePath));
                //string[] lines = File.ReadAllLines(sourcePath);
                //foreach (string line in lines)
                //{
                //    File.WriteAllText(targetPath, line);
                //}
                //fs = new FileStream(sourcePath, FileMode.Open);
                //sr = new StreamReader(fs);

                sr = File.OpenText(sourcePath);
                string line = sr.ReadToEnd();
                Console.WriteLine(line);
                
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");

            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }         
            }
        }
    }
}
