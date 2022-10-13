using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    internal class PathCommands
    {
        public string SourcePath { get; set; }

        public PathCommands(string sourcePath)
        {
            SourcePath = sourcePath;
        }

        public void UsingPathCommands ()
        {
            Console.WriteLine("DirectorySeparatorChar " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(SourcePath));
            Console.WriteLine("GetFileName: " + Path.GetFileName(SourcePath));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(SourcePath));
            Console.WriteLine("GetExtension: " + Path.GetExtension(SourcePath));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(SourcePath));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        }

    }
}
