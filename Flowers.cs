using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISYS3393Homework3
{
    class Flowers
    {
        private System.Drawing.Image flowerImage;
        private string flowerName;

        public Flowers(string name, System.Drawing.Image image)
        {
            flowerName = name;
            flowerImage = image;
        }

        public string Name
        {
            get
            {
                return flowerName;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return flowerImage;
            }
        }
    }
}
