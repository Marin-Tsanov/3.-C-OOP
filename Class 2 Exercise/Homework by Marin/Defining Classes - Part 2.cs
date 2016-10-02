
namespace Homework_by_Marin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Defining_Classes_Part_2
    {
        static void Main()
        {
            var Point3D = new Point3D();
            Point3D.X = 4.5;
            Point3D.Y = 5.8;
            Point3D.Z = 8.2;

            var Point3D1 = new Point3D();
            Point3D1.X = 4.5;
            Point3D1.Y = 5.8;
            Point3D1.Z = 8.2;

            //Console.WriteLine(Point3D.ToString());

            //Console.WriteLine(Distance.CalculateDistance(Point3D,Point3D1));

            Path PointStore = new Path();

            PointStore.AddPoint(Point3D);
            PointStore.AddPoint(Point3D1);

            //Console.WriteLine(PointStore.AllPoints);

            Console.WriteLine(PathStorage.ReturnPath());

            var myList = new GenericList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine(myList.ToString());

            Matrix<int> first = new Matrix<int>(2, 2);
            Matrix<int> second = new Matrix<int>(2, 2);

            int k = 0;

            for (int i = 0; i < first.Row; i++)
            {
                for (int j = 0; j < first.Col; j++)
                {
                    first[i, j] = k;
                    k++;
                }
            }

            k = 0;

            for (int i = 0; i < second.Row; i++)
            {
                for (int j = 0; j < second.Col; j++)
                {
                    second[i, j] = k;
                    k++;
                }
            }

            var result1 = first + second;

            for (int i = 0; i < result1.Row; i++)
            {
                for (int j = 0; j < result1.Col; j++)
                {
                    Console.Write("{0} ",result1[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var result2 = first - second;

            for (int i = 0; i < result2.Row; i++)
            {
                for (int j = 0; j < result2.Col; j++)
                {
                    Console.Write("{0} ", result2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var result3 = first * second;
            for (int i = 0; i < result3.Row; i++)
            {
                for (int j = 0; j < result3.Col; j++)
                {
                    Console.Write("{0} ", result3[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            if (first)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
