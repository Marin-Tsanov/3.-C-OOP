using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9___19
{
    public static class ExtractMarks
    { 
        public static List<int> ExtractMarks06(this List<Student> list)
        {
            List<int> marks = new List<int>();

            foreach (var item in list)
            {
                if (item.FN % 100 == 6)
                {
                    marks.AddRange(item.Marks);
                }
            }
            return marks;
        }
    }
}
