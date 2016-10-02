

namespace Homework_by_Marin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public struct Point3D
    {
        private static readonly Point3D origin =
            new Point3D() { X = 0, Y = 0, Z = 0 };

        private double x;
        private double y;
        private double z;
        
        // constructor

        public Point3D(double x, double y, double z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Properties 
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D Origin
        {
            get
            {
                return origin;
            }
        }
        // override ToString()

            public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y,this.Z);
        }
    }
}
