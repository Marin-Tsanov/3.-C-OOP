using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    public class Display
    {
        // fields

        private double width;
        private double height;
        private int numberofcolors;

        // Constructors

        public Display()
        {
        }

        public Display(double width, double height) : this()
        {
        }

        public Display(double width, double height, int numberofcolors)
            : this()
        {
            this.Width = width;
            this.Height = height;
            this.Numberofcolors = numberofcolors;
        }

        // Properties

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width's value can not  be less than 0");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height's value can not be less than 0");
                }
                this.height = value;
            }
        }

        public int Numberofcolors
        {
            get { return this.numberofcolors; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Display is not  working, go to the service station");
                }
                this.numberofcolors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}",
                this.width, this.height, this.numberofcolors);
        }
    }
}
