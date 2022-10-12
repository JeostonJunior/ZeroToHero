using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main (string[] args)
        {
            string sourcePath = @"c:\Users\jeoston.araujo\Documents\ZeroToHero\TrabalhandoComArquivos\MyFolder";
            string targetPath = @"c:\Users\jeoston.araujo\Documents\ZeroToHero\TrabalhandoComArquivos\text2.txt";
            //FileStream fs = null;
            //StreamReader sr = null;
            //try
            //{
            //    using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            Console.WriteLine(sr.ReadToEnd());
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    //string[] content = File.ReadAllLines(sourcePath);
            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {                    
            //        //StreamReader content = new StreamReader(sourcePath);
            //        //string content2 = content.ReadToEnd();
            //        sw.WriteLine(File.ReadAllText(sourcePath).ToString().ToUpper());
            //    }
            //    using (FileStream fs = new FileStream(targetPath, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            Console.WriteLine(sr.ReadToEnd());
            //        }
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            try
            {
                Directorys directory = new Directorys(sourcePath);
                directory.UsingDirectoriesDirectory();

                directory.UsingFilesDirectory();

                directory.CreateFolderDirectory(@"\teste2");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }



            //try
            //{
            //    ////FileInfo fileInfo = new FileInfo(sourcePath);
            //    ////fileInfo.CopyTo(targetPath);
            //    ////File.WriteAllLines(targetPath, File.ReadAllLines(sourcePath));
            //    //string[] lines = File.ReadAllLines(sourcePath);
            //    //foreach (string line in lines)
            //    //{
            //    //    File.WriteAllText(targetPath, line);
            //    //}
            //    //fs = new FileStream(sourcePath, FileMode.Open);
            //    //sr = new StreamReader(fs);

            //    //sr = File.OpenText(sourcePath);
            //    //string line = sr.ReadToEnd();
            //    //Console.WriteLine(line);






            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine($"An error occurred: {e.Message}");

            //}
            //finally
            //{
            //    if(sr != null)
            //    {
            //        sr.Close();
            //    }         
            //}
        }
    }
}
