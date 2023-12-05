using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._18_Constructors
{
    class book
    {
        public string title;
        public string author;
        public int pages;

        public book(string eTitle, string aAuthor, int aPages)
        {
            title = eTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
