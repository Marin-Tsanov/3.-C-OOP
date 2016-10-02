using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_3__
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student {FirstName = "Hristina", LastName = "Pavlova", Age= 20},
            new Student {FirstName = "Marin", LastName = "Tsanov",Age = 30 },
            new Student {FirstName = "Momchil",LastName = "Milev",Age = 22 },
            new Student {FirstName="Atanas",LastName="Vanov" , Age = 28},
            new Student {FirstName="Qnislav",LastName="Tachev" , Age = 26}
        };
            // Problem 3. First before last

            var firstBeforeLast =
                from student in students
                where (string.Compare(student.FirstName, student.LastName) == -1)
                select student;

            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }

            Console.WriteLine("------------");

            // Problem 4. Age range

            var ageRange =
                from student in students
                where (student.Age >= 18 && student.Age <= 24)
                select new { student.FirstName, student.LastName };

            foreach (var student in ageRange)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("------------");

            // Problem 5. Order students

            var sortedStudents =
                students.OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }

            Console.WriteLine();

            var sortedStudents2 =
                students.OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName);

            foreach (var student in sortedStudents2)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("------------");
        }
    }
}
