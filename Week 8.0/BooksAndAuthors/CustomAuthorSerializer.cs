using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    class CustomAuthorSerializer : IAuthorSerializer
    {
        public Author DeserializeAuthor(string file)
        {
            string[] lines = File.ReadAllLines(file);
            List<Book> books = new List<Book>();

            if (lines.Length == 0)
            {
                return new Author(string.Empty, string.Empty, new List<Book>());
            }

            else if (lines.Length == 1)
            {
                return new Author(lines[0], string.Empty, new List<Book>());
            }

            else if (lines.Length == 2)
            {
                return new Author(lines[0], lines[1], new List<Book>());
            }

            for (int i = 2; i < lines.Length; i++)
            {
                var bookInfo = lines[i].Split('$');
                books.Add(new Book(bookInfo[0], Convert.ToDateTime(bookInfo[1])));
            }
            return new Author(lines[0], lines[1], books);
        }

        public void SerializeAuthor(Author author, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(author.Name);
                sw.WriteLine(author.Email);

                foreach (var book in author.Books)
                {
                    sw.WriteLine(string.Join("$", book.Title, book.PublishDate));
                }
            }
        }
    }
}
