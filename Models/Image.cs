using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Image:Element
    {

        private string _imageName;

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

        public Image(string imageTitle)
        {
            ImageName = imageTitle;
        }

        public override void Print()
        {
            Console.WriteLine($"Image name: {_imageName}");
        }
    }
}
