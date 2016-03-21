using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> dSteelBooks = new List<Book>() { new Book("Lone Eagle", DateTime.Now.AddYears(-15)), new Book("Sisters", DateTime.Now.AddYears(-9))};
            Author dSteel = new Author("Danielle Steel", "dsteel@gmail.com", dSteelBooks);

            CustomAuthorSerializer serializer = new CustomAuthorSerializer();
            serializer.SerializeAuthor(dSteel, @"C:\Users\IVAN\Desktop\Programming-101-CSharp\Week 8.0\testAuthor.txt");

            Console.WriteLine("--------------Serialize---------------");

            using (StreamReader sr = new StreamReader(@"C:\Users\IVAN\Desktop\Programming-101-CSharp\Week 8.0\testAuthor.txt"))
            {
                string line;
                while ((line = sr.ReadLine())!= null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("-------------Deserialize---------------");

            var newAuthor = serializer.DeserializeAuthor(@"C:\Users\IVAN\Desktop\Programming-101-CSharp\Week 8.0\testAuthor.txt");
            Console.WriteLine("Name: " + newAuthor.Name);
            Console.WriteLine("Email: " + newAuthor.Email);
            
            foreach (var book in newAuthor.Books)
            {
                Console.WriteLine(book.Title + "$" + book.PublishDate);
            }
        }
    }
}
