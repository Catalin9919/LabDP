using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {

        private string _bookName;

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        private List<Chapter> _chapters;

        public List<Chapter> Chapters
        {
            get { return _chapters; }
            set { _chapters = value; }
        }

        private Author _author;

        public Author Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public Book(string bookName):this()
        {
            BookName = bookName;
        }

        public Book()
        {
            Chapters = new List<Chapter>();
        }

        public void AddAuthor(Author currentAuthor)
        {
            Author = currentAuthor;
        }

        public int CreateChapter(string chapterName)
        {
            Chapter newChapter = new Chapter(chapterName);
            Chapters.Add(newChapter);
            return Chapters.Count;
        }
        
        public Chapter GetChapter(int chapterIndex)
        {
            return Chapters.ElementAt(chapterIndex-1);
        }
    }
}
