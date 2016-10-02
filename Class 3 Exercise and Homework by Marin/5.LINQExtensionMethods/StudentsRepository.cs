using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.LINQExtensionMethods
{
    public class StudentsRepository
    {
        public IEnumerable<Student> GetAllStudents()
        {
            var oop = new Course { Id = 1, Name = "OOP" };
            var csharp = new Course { Id = 2, Name = "CSharp" };
            var javaScript = new Course { Id = 3, Name = "JavaScript" };
            var students = new List<Student>
        {
            new Student
                {
                    Id = 1,
                    Name = "Ivan",
                    Courses = new List<Course> { oop, javaScript },
                    Mark = 5
            },
            new Student
                {
                    Id = 2,
                    Name = "Gosho",
                    Courses =
                        new List<Course> { oop, javaScript, csharp },
                    Mark = 4
            },
            new Student
                {
                    Id = 3,
                    Name = "Pesho",
                    Courses = new List<Course> { csharp, javaScript },
                    Mark = 4
            },
        };

            return students;
        }
    }
}