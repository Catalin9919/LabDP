using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SubChapter
    {
        private string _subChapterTitle;

        public string SubChapterTitle
        {
            get { return _subChapterTitle; }
            set { _subChapterTitle = value; }
        }

        private List<Paragraph> paragraphs;

        public List<Paragraph> Paragraphs
        {
            get { return paragraphs; }
            set { paragraphs = value; }
        }

        private List<Image> _images;

        public List<Image> Images
        {
            get { return _images; }
            set { _images = value; }
        }

        private List<Table> _tables;

        public List<Table> Tables
        {
            get { return _tables; }
            set { _tables = value; }
        }

        public SubChapter(string subChapterName):this()
        {
            SubChapterTitle = subChapterName;
        }

        public SubChapter()
        {
            Paragraphs = new List<Paragraph>();
            Images = new List<Image>();
            Tables = new List<Table>();
        }

        public int CreateParagraph(string paragraphTitle)
        {
            Paragraph newParagraph = new Paragraph(paragraphTitle);
            Paragraphs.Add(newParagraph);
            return Paragraphs.Count;
        }

        public Paragraph GetParagraph(int indexOfParagraph)
        {
            return Paragraphs.ElementAt(indexOfParagraph - 1);
        }

        public int CreateImage(string imageName)
        {
            Image newImage = new Image(imageName);
            Images.Add(newImage);
            return Images.Count;
        }

        public Image GetImage(int indexOfImage)
        {
            return Images.ElementAt(indexOfImage);
        }

        public int CreateTable(string tableName)
        {
            Table newTable = new Table(tableName);
            Tables.Add(newTable);
            return Tables.Count;
        }

        public Table GetTable(int indexOfTable)
        {
            return Tables.ElementAt(indexOfTable);
        }
    }
}
