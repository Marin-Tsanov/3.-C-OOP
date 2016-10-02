
namespace Homework_by_Marin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class Path 
    {
        //private List<Point3D> pointPath = 
        //    new List<Point3D>();

        //public List<Point3D> PointPath { get; set; }

        //public string /*Point3D*/ AllPoints
        //{
        //    get
        //    {
        //        string pointInfo = string.Empty;
        //        foreach (var item in this.pointPath)
        //        {
        //            pointInfo+= item.ToString()+"\n";
        //        }
        //        return pointInfo;
        //    }
        //}

        public void AddPoint(Point3D pointToAdd)
        {
            //this.pointPath.Add(pointToAdd);
            using (StreamWriter writer = new StreamWriter("E:\\file.txt", true))
            {
                writer.WriteLine(pointToAdd);
            }
        }
    }
}
