using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper
{
    class Program
    {
        public static void ToUpper(FileInfo file, FileInfo newFile)
        {
            using (StreamReader firstFile = new StreamReader(file.FullName))
            {
                using (StreamWriter secondFile = new StreamWriter(newFile.FullName))
                {
                    secondFile.WriteLine(firstFile.ReadLine().ToUpper());
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("File to convert:");
            string path = Console.ReadLine();

            while (!File.Exists(path))
            {
                Console.WriteLine("You entered non existing file. Try again:");
                path = Console.ReadLine();
            }

            FileInfo file = new FileInfo(path);
            Console.WriteLine("Enter the new fie:");
            path = Console.ReadLine();
            FileInfo newFile = new FileInfo(path);

            ToUpper(file, newFile);

            using (StreamReader sr = new StreamReader(newFile.FullName))
            {
                string line;
                
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
