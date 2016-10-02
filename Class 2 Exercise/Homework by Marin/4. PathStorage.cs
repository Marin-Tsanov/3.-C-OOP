

namespace Homework_by_Marin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public static class PathStorage
    {
		public static string ReturnPath()
        {
            string returnPath = File.ReadAllText("E:\\file.txt");

            return returnPath;
        }


    }
}
