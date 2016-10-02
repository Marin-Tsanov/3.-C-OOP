using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.LINQExtensionMethods
{
   public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Mark { get; set; }

        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return this.Id + "; Name: " + this.Name + "; Courses: " + this.Courses.Count;
        }
    }
}
