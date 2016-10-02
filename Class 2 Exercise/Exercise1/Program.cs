using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            {
                //using (StreamWriter writer = new StreamWriter("E:\\file.txt", true))
                //{
                //    writer.WriteLine("Important data line 1");
                //    writer.WriteLine("Important data line 2");
                //}

                //string value1 = File.ReadAllText("E:\\file.txt");

                //Console.WriteLine("--- Contents of file.txt: ---");
                //Console.WriteLine(value1); 

                string[] myArray = { "a", "b", "c", "d", "e" };
                //int indexToRemove = 1;
                //myArray = myArray.Where((source, index) => index != indexToRemove).ToArray();

                Array.Resize(ref myArray, myArray.Length * 2);

                foreach (var item in myArray)
                {
                    Console.WriteLine(item);
                }

                int[] array = { 0, 1, 2, 3, 0, 1 };

                string result = string.Join("", array);
                Console.WriteLine(result);

                int[,] arrayA = new int[,]
                {
                    {4,1,0},
                    {0,-2,3},
                    {1,5,6},
                };

                int[,] arrayB = new int[,]
                {
                    {1,-1},
                    {2,3},
                    {-5,1},
                };

                int[,] arrayC = new int[3, 2];

                for (int i = 0; i < arrayA.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayB.GetLength(1); j++)
                    {
                        //arrayC[i, j] = 0;

                        for (int k = 0; k < arrayB.GetLength(0); k++)
                        {
                            arrayC[i, j] += arrayA[i, k]*arrayB[k, j];
                        }
                    }
                }


                for (int i = 0; i < arrayC.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayC.GetLength(1); j++)
                    {
                        Console.Write("{0} ", arrayC[i, j]);
                    }
                    Console.WriteLine();
                }


            }
        }
    }
}
