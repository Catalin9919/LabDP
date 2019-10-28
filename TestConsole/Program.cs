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
            Book discoTitanic = new Book("Titanic");
            Author rPowel = new Author("Radu Powell");
            discoTitanic.AddAuthor(rPowel);

            #region Part1
            //int indexOfChapter = discoTitanic.CreateChapter("Chapter One");
            //Chapter chptOne = discoTitanic.GetChapter(indexOfChapter);
            //int indexOfSubChapter = chptOne.CreateSubChapter("chpt 1 1");
            //SubChapter chptOneOne = chptOne.GetSubChapter(indexOfSubChapter);
            //int indexOfParagraph = chptOneOne.CreateParagraph("Paragraph");
            //Paragraph paragraph1 = chptOneOne.GetParagraph(indexOfParagraph);
            //int indexOfImage1 = chptOneOne.CreateImage("Image");
            //Image image1 = chptOneOne.GetImage(indexOfImage1);
            //int indexOfImage2 = chptOneOne.CreateImage("Image");
            //Image image2 = chptOneOne.GetImage(indexOfImage2);
            //int indexOfImage3 = chptOneOne.CreateImage("Image");
            //Image image3 = chptOneOne.GetImage(indexOfImage3);
            //int indexOfTable = chptOneOne.CreateTable("Table");
            //Table table1 = chptOneOne.GetTable(indexOfTable);

            //ConsoleLog(discoTitanic);
            #endregion

            #region Composition_Pattern
            //Section chpt1 = new Section("Chapter 1");
            //Section chpt11 = new Section("Chapter 1.1");
            //Section chpt111 = new Section("Chapter 1.1.1");
            //Section chpt1111 = new Section("Chapter 1.1.1.1");
            //discoTitanic.AddContent(new Paragraph("Paragraph pentru carte"));
            //discoTitanic.AddContent(chpt1);

            //chpt1.AddElement(new Paragraph("Moto capitol"));
            //chpt1.AddElement(chpt11);

            //chpt11.AddElement(new Paragraph("Text from SubChapter 1.1"));
            //chpt11.AddElement(chpt111);

            //chpt111.AddElement(new Paragraph("Text from subchapter 1.1.1"));
            //chpt111.AddElement(chpt1111);

            //chpt1111.AddElement(new Image("Image from subchapter 1.1.1.1"));

            //discoTitanic.Print();
            #endregion

            #region Threading+Proxy_Pattern

            long StartTime = DateTime.Now.Ticks;
            Image img1 = new Image("Image 1");
            Image img2 = new Image("Image 2");
            Image img3 = new Image("Image 3");

            Section section1 = new Section("Section 1");
            section1.AddElement(img1);

            Section section2 = new Section("Section 2");
            section2.AddElement(img2);
            section2.AddElement(img3);

            Book book1 = new Book("Book 1");
            book1.AddContent(section1);
            book1.AddContent(section2);
            long EndTime = DateTime.Now.Ticks;

            Console.WriteLine($"Creation of the content took {TimeSpan.FromTicks(EndTime - StartTime).TotalMilliseconds} miliseconds.");

            StartTime = DateTime.Now.Ticks;
            section1.Print();
            EndTime = DateTime.Now.Ticks;
            Console.WriteLine($"Printing the first section took {TimeSpan.FromTicks(EndTime - StartTime).TotalMilliseconds} miliseconds.");

            StartTime = DateTime.Now.Ticks;
            section1.Print();
            EndTime = DateTime.Now.Ticks;
            Console.WriteLine($"Printing the first section again took {TimeSpan.FromTicks(EndTime - StartTime).TotalMilliseconds} miliseconds.");



            #endregion

            Console.Read();
        }

        #region First_Console_Log
        //private static void ConsoleLog(Book currentBook)
        //{
        //    foreach (var author in currentBook.Authors)
        //    {
        //        Console.WriteLine(author.AuthorName);
        //    }
        //    Console.WriteLine(currentBook.BookName);

        //    foreach (var chapter in currentBook.Chapters)
        //    {
        //        Console.WriteLine(chapter.ChapterTitle);

        //        foreach (var subChapter in chapter.SubChapters)
        //        {
        //            Console.WriteLine(subChapter.SubChapterTitle);

        //            foreach (var paragraph in subChapter.Paragraphs)
        //            {
        //                Console.WriteLine(paragraph.ParagraphName);
        //            }

        //            foreach (var image in subChapter.Images)
        //            {
        //                Console.WriteLine(image.ImageName);
        //            }

        //            foreach (var table in subChapter.Tables)
        //            {
        //                Console.WriteLine(table.TableName);
        //            }
        //        }

        //    }
        //}
        #endregion
    }
}
