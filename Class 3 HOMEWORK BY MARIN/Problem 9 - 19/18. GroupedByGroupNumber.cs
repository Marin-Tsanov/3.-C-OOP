using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9___19
{
    public static class GroupedByGroupNumber
    {
        public static void Grouped(this List<Student> list)
        {
            var groupList =
                from item in list
                group item by item.GroupNumber;

            foreach (var group in groupList)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item.firstName);
                }
                Console.WriteLine("---------");
            }
        }
    }
}
