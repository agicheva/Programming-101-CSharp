using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameHistogram
{
    class Program
    {
        public static Dictionary<string, int> FileNameHistogram(DirectoryInfo dir)
        {
            Dictionary<string, int> allFiles = new Dictionary<string, int>();
            FileNameHistogramRecursion(dir, allFiles);
            return allFiles;
        }

        private static void FileNameHistogramRecursion(DirectoryInfo dir, Dictionary<string, int> allFiles)
        {
            DirectoryInfo[] subDirs = null;
            FileInfo[] filesInDir = null;

            try
            {
                subDirs = dir.GetDirectories();
                filesInDir = dir.GetFiles();
            }
            catch (UnauthorizedAccessException)
            {

            }

            if (filesInDir != null)
            {
                foreach (var file in filesInDir)
                {
                    if (!allFiles.ContainsKey(file.Name))
                    {
                        allFiles.Add(file.Name, 1);
                    }
                    else
                    {
                        allFiles[file.Name]++;
                    }
                }

                if (subDirs != null)
                {
                    foreach (var subDir in subDirs)
                    {
                        FileNameHistogramRecursion(subDir, allFiles);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory:");
            string path = Console.ReadLine();

            while (!Directory.Exists(path))
            {
                Console.WriteLine("That directory does not exist. Please, write a valid directory:");
                path = Console.ReadLine();
            }

            var directory = new DirectoryInfo(path);
            var allFiles = FileNameHistogram(directory);

            foreach (var file in allFiles)
            {
                Console.WriteLine(file.Key + ": " + file.Value);
            }
        }
    }
}
