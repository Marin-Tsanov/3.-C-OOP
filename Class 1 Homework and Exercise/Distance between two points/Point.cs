

namespace Distance_between_two_points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Point
    {
        private double xcoord;
        private double ycoord;

        public Point(double xcoord, double ycoord)
        {
            this.Xcoord = xcoord;
            this.Ycoord = ycoord;
        }
        
        public double Xcoord
        {
            get {return this.xcoord; }
            set { this.xcoord = value; }
        }

        public double Ycoord
        {
            get { return this.ycoord; }
            set { this.ycoord = value; }
        }

        public static double Distance(Point A, Point B)
        {
            double result = Math.Sqrt((A.xcoord - B.xcoord) * (A.xcoord - B.xcoord) 
                                    + (A.ycoord - B.ycoord) * (A.ycoord - B.ycoord));
            return result;
        } 
    }
}
