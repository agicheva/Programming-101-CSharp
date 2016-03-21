using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    [Serializable]
    class Author
    {
        private string name;
        private string email;
        private List<Book> books;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public List<Book> Books
        {
            get
            {
                return books;
            }

            set
            {
                books = value;
            }
        }

        public Author()
        {

        }

        public Author(string name, string email, List<Book> books)
        {
            Name = name;
            Email = email;
            Books = books;
        }
    }
}
