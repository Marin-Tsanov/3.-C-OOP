using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9___19
{
    public static class StudentExtensions
    {
        public static List<Student> GroupStudents(this List<Student> list)
        {
            List<Student> groupNumber2 = new List<Student>();
            foreach (var item in list)
            {
                if (item.GroupNumber == 2)
                {
                    groupNumber2.Add(item);
                }
            }
            List<Student> OrderedList =
            groupNumber2.OrderBy(student => student.firstName).ToList();

            return OrderedList;
        }
    }
}
