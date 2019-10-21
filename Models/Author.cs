using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Author
    {

        private string _authorName;

        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public Author(string authorName)
        {
            AuthorName = authorName;
        }

    }
}
