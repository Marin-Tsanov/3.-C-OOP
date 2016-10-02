using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9___19
{
    public static class Phone
    {
        public static List<Student> PhoneSofia(this List<Student> list, string word)
        {
            var phonesSofia =
                from item in list
                where ((item.Tel).ToString()).IndexOf(word) == 0
                select item;

            return phonesSofia.ToList<Student>();
        }
    }
}
