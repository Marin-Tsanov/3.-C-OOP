

namespace Rectangle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Rectangle
    {
        public double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        public double Width
        {
            get { return this.width; }

            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Width's value must be greater than 0");
                }
                this.width = value;
                }
        }

        public double Height
        {
            get { return this.height; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Heigth's value must be greater than 0");
                }
                this.height = value;
            }
        }

        public static double Area(Rectangle A)
        {
            double result = A.width*A.height;
            return result;
        }
    }
}
