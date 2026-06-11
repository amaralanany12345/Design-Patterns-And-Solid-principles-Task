using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.ProxyPattern
{
    internal class ProxyImage : IImage
    {
        private RealImage _realImage;

        public ProxyImage()
        {
            _realImage = new RealImage();
            CheckImage();
        }

        private void CheckImage()
        {
            Console.WriteLine("checking from proxy");
        }

        public void Display()
        {
            _realImage.Display();   
        }
    }
}
