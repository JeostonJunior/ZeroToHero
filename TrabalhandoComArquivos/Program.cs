using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main ()
        {
            string sourcePath = @"c:\Users\jeoston.araujo\Documents\ZeroToHero\TrabalhandoComArquivos\MyFolder\text1.txt";
            string targetPath = @"c:\Users\jeoston.araujo\Documents\ZeroToHero\TrabalhandoComArquivos\text2.txt";

            try
            {
                PathCommands path = new PathCommands(sourcePath);
                path.UsingPathCommands();

            }
            catch (Exception)
            {

                throw;
            }


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

            //USING FILESTREAM AND STREAMREADER
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

            //USING DIRECTORY AND DIRECTORYINFO
            //try
            //{
            //    Directorys directory = new Directorys(sourcePath);
            //    directory.UsingDirectoriesDirectory();

            //    directory.UsingFilesDirectory();

            //    directory.CreateFolderDirectory(@"\teste2");

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //USING FILE AND FILEINFO
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
