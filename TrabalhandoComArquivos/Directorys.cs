using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    internal class Directorys
    {
        public string SourcePath { get; set; }

        public Directorys(string sourcePath)
        {
            SourcePath = sourcePath;
        }

        public void UsingDirectoriesDirectory ()
        {
            IEnumerable<string> folders =  Directory.EnumerateDirectories(SourcePath, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS:");
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
            }
        }

        public void UsingFilesDirectory ()
        {
            IEnumerable<string> files = Directory.EnumerateFiles(SourcePath, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES:");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }

        public void CreateFolderDirectory (string folder)
        {
            Directory.CreateDirectory(SourcePath + folder);
        }

    }
}
