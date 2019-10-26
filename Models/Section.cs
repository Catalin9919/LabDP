using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Section:Element
    {
        private string _sectionTitle;

        public string SectionTitle
        {
            get { return _sectionTitle; }
            set { _sectionTitle = value; }
        }

        public List<Element> content;

        public Section(string Title)
        {
            _sectionTitle = Title;
            content = new List<Element>();
        }

        public int AddElement(Element element)
        {
            content.Add(element);
            return content.IndexOf(element);
        }

        public void RemoveElement(Element element)
        {
            content.Remove(element);
        }

        public Element GetElement(int indexOfElement)
        {
            return content.ElementAt(indexOfElement);
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {_sectionTitle}");
            foreach (var element in content)
            {
                element.Print();
            }
        }
    }
}
