using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Paragraph:Element
    {
        private AlignStrategy _alignStrategy;
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
            if (_alignStrategy == null)
            {
                Console.WriteLine(_paragraphName);
            }
            else
            {
                _alignStrategy.Print(_paragraphName);
            }
        }

        public void SetAlignStrategy(AlignStrategy strategy)
        {
            _alignStrategy = strategy;
        }

    }
}
