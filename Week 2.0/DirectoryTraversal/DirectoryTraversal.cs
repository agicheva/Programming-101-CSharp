using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryTraversal
{
    class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\IVAN\Desktop\C-Sharp-Projects");
            foreach (var item in IterateDirectory(dir))
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<string> IterateDirectory(DirectoryInfo dir)
        {
            
            foreach (var item in dir.GetDirectories())
            {
                yield return item.Name;
                foreach (var file in item.GetFiles())
                {
                    yield return file.Name;
                }
                foreach (var directory in IterateDirectory(item))
                {
                    yield return directory;
                }
            }

        }
    }
}
