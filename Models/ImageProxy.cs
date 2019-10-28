using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ImageProxy:Element
    {

        private string _imageTitle;

        public string ImageTitle
        {
            get { return _imageTitle; }
            set { _imageTitle = value; }
        }

        private Image _realImage;

        public Image RealImage
        {
            get { return _realImage; }
            set { _realImage = value; }
        }

        public ImageProxy(string imageName)
        {
            this._imageTitle = imageName;
        }

        public void Print()
        {
            _realImage = new Image(ImageTitle);
            _realImage.Print();
        }
    }
}
