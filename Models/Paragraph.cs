using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Paragraph:Element
    {
        private string _paragraphName;

        public string ParagraphName
        {
            get { return _paragraphName; }
            set { _paragraphName = value; }
        }

        public Paragraph(string paragraphTitle)
        {
            ParagraphName = paragraphTitle;
        }

        public void Print()
        {
            Console.WriteLine($"Paragraph name: {_paragraphName}");
        }
    }
}
