using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9___19
{
    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    firstName = "Marin",
                    lastName  = "Popov",
                    FN        = 2016324,
                    Tel       = 0886543298,
                    email     = "ivan.hlebarov@yahoo.com",
                    Marks     = new List<int> {2,6,3,5,4 },
                    GroupNumber = 1
                },

                 new Student
                {
                    firstName = "Marin",
                    lastName  = "Tsanov",
                    FN        = 2016316,
                    Tel       = 0883356981,
                    email     = "marin.tsanov@abv.bg",
                    Marks     = new List<int> {2,3,5,4 },
                    GroupNumber = 2
                },

                new Student
                {
                    firstName = "Hristina",
                    lastName  = "Pavlova",
                    FN        = 2016306,
                    Tel       = 0283655533,
                    email     = "hristina.pavlova@abv.bg/*gfk.com*/",
                    Marks     = new List<int> {2,2,3,5,4 },
                    GroupNumber = 2
                }
            };

            // Problem 9. Student groups

            Console.WriteLine("Student groups:");

            var studentsGroup2 =
                from student in students
                where student.GroupNumber == 2
                orderby student.firstName
                select student;
            
            foreach (var num in studentsGroup2)
            {
                Console.WriteLine(num.firstName);
            }

            Console.WriteLine("------------");

            // Problem 10. Student groups extensions

            Console.WriteLine("Student groups extensions:");

            List<Student> studentsGroup2Again = students.GroupStudents();

            foreach (var num in studentsGroup2Again)
            {
                Console.WriteLine(num.firstName);
            }

            Console.WriteLine("------------");

            // Problem 11. Extract students by email

            Console.WriteLine("Extract students by email:");

            List <Student> studentsGroupByEmail = students.EmailList("abv.bg");

            foreach (var num in studentsGroupByEmail)
            {
                Console.WriteLine(num.firstName);
            }

            Console.WriteLine("------------");

            // Problem 12. Extract students by phone

            Console.WriteLine("Extract students by phone:");

            List<Student> studentsGroupByPhone = students.PhoneSofia("2");

            foreach (var num in studentsGroupByPhone)
            {
                Console.WriteLine(num.firstName);
            }

            Console.WriteLine("------------");

            // Problem 13. Extract students by marks

            Console.WriteLine("Extract students by marks:");

            var anonymousData =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.firstName + " " + student.lastName,
                    Marks = student.Marks
                };

            foreach (var m in anonymousData)
            {
                Console.WriteLine("Name : {0}",m.FullName);
                foreach (var item in m.Marks)
                {
                    Console.WriteLine("Mark : {0}", item);
                } 
            }

            Console.WriteLine("------------");

            // Problem 14.Extract students with two marks
            Console.WriteLine("Extract students with two marks 2 :");
            List <Student> twoMarksOf2 = students.TwoMarks2();

            foreach (var num in twoMarksOf2)
            {
                Console.WriteLine(num.firstName);
            }

            Console.WriteLine("------------");

            // Problem 15. Extract marks
            Console.WriteLine("Extract marks :");

            List<int> exctractMarks = students.ExtractMarks06();
            foreach (var mark in exctractMarks)
            {
                Console.WriteLine(mark);
            }

            Console.WriteLine("------------");

            // Problem 18. Grouped by GroupNumber

            Console.WriteLine("Grouped by GroupNumber :");

            students.Grouped();

            Console.WriteLine("------------");

            // Problem 19. Grouped by GroupName extensions
            Console.WriteLine(" Grouped by GroupName extensions :");
            students.GroupName();

            //Console.WriteLine("------------");

            //Console.WriteLine("------------");

        }
    }
}
