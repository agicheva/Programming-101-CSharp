using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    [Serializable]
    class Book
    {
        private string title;
        private DateTime publishDate;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public DateTime PublishDate
        {
            get
            {
                return publishDate;
            }

            set
            {
                publishDate = value;
            }
        }

        public Book()
        {

        }

        public Book(string title, DateTime publishDate)
        {
            Title = title;
            PublishDate = publishDate;
        }
    }
}
