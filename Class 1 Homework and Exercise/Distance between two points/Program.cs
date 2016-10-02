using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_between_two_points
{
    class Program
    {
        static void Main()
        {
            Point A = new Point(1.0,1.0);
            Point B = new Point(2.0, 2.0);
            
            Console.WriteLine(Point.Distance(A,B));
        }
    }
}
