using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Book TitanicBook = new Book("Titanic");
            Author rPowel = new Author("Radu Powell");
            TitanicBook.AddAuthor(rPowel);
            int indexOfChapter = TitanicBook.CreateChapter("Chapter One");
            Chapter chptOne = TitanicBook.GetChapter(indexOfChapter);
            int indexOfSubChapter = chptOne.CreateSubChapter("chpt 1 1");
            SubChapter chptOneOne = chptOne.GetSubChapter(indexOfSubChapter);
            int indexOfParagraph = chptOneOne.CreateParagraph("Paragraph");
            int indexOfImage = chptOneOne.CreateImage("Image");
            int indexOfTable = chptOneOne.CreateTable("Table");
            
            Console.Read();
        }
    }
}
