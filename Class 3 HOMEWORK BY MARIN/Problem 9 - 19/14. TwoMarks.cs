using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9___19
{
    public static class TwoMarks
    {
        public static List<Student> TwoMarks2(this List<Student> list)
        {
            List<Student> twoMarks = new List<Student>();
            int count = 0;

            foreach (var item in list)
            {
                for (int i = 0; i < item.Marks.Count; i++)
                {
                    if (item.Marks[i] == 2)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    twoMarks.Add(item);
                }
                count = 0;
            }

            return twoMarks;
        }
    }
}
