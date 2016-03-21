using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    interface IAuthorSerializer
    {
        void SerializeAuthor(Author author, string file);
        Author DeserializeAuthor(string file);
    }
}
