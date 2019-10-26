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

        //private List<Chapter> _chapters;

        //public List<Chapter> Chapters
        //{
        //    get { return _chapters; }
        //    set { _chapters = value; }
        //}

        private List<Element> _content;

        public List<Element> Content
        {
            get { return _content; }
            set { _content = value; }
        }


        private List<Author> _authors;

        public List<Author> Authors
        {
            get { return _authors; }
            set { _authors = value; }
        }


        public Book(string bookName):this()
        {
            BookName = bookName;
        }

        public Book()
        {
            //Chapters = new List<Chapter>();
            _content = new List<Element>();
            Authors = new List<Author>();
        }

        public void AddAuthor(Author currentAuthor)
        {
            Authors.Add(currentAuthor);
        }

        public void AddContent(Element element)
        {
            _content.Add(element);
        }

        public void Print()
        {

            Console.WriteLine($"Book Title: {_bookName}");
            foreach (var author in Authors)
            {
                Console.WriteLine($"Authors: {author.AuthorName}");
            }

            foreach (var element in Content)
            {
                element.Print();
            }

        }

        //public int CreateChapter(string chapterName)
        //{
        //    Chapter newChapter = new Chapter(chapterName);
        //    Chapters.Add(newChapter);
        //    return Chapters.Count;
        //}

        //public Chapter GetChapter(int chapterIndex)
        //{
        //    return Chapters.ElementAt(chapterIndex-1);
        //}
    }
}
