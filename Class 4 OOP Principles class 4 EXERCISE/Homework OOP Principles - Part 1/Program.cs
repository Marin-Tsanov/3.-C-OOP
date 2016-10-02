using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles___Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] array = { 'A' };
            //Console.WriteLine(char.IsLetter(array[0]));

            //Human marin = new Human("Marin", "Tsanov");
            //Console.WriteLine(marin.Firstname);
            //Console.WriteLine(marin.Lastname);

            List<Student> studentList = new List<Student>(); /*new Student("Ivan", "Ivanov",5);*/

            studentList.Add(new Student("Ivan", "Ivanov", 5));
            studentList.Add(new Student("Pesho", "Peshev", 4));
            studentList.Add(new Student("Marin", "Tsanov", 3));
            studentList.Add(new Student("Hristina", "Pavlova", 1));
            studentList.Add(new Student("Tseko", "Sifona", 2));
            studentList.Add(new Student("Emsi", "Faraona", 2));
            studentList.Add(new Student("Ivan", "Jelev", 3));
            studentList.Add(new Student("BJ", "Penn", 4));
            studentList.Add(new Student("The", "RealDeal", 2));
            studentList.Add(new Student("Gesho", "Geshev", 3));

            var studentAscending =
                from student in studentList
                orderby student.Grade
                select student;

            foreach (var element in studentAscending)
            {
                Console.WriteLine(" {0} {1}",element.FullName(),element.Grade);
            }

            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine();

            List<Worker> workerList = new List<Worker>()/*("Pesho", "Peshev", 100, 2)*/;

            workerList.Add(new Worker("Iva", "Ivanova", 500,3));
            workerList.Add(new Worker("Pisho", "Pishev", 50,1));
            workerList.Add(new Worker("Martin", "Tsenov", 300,2));
            workerList.Add(new Worker("Hristiana", "Pavleva", 100,1));
            workerList.Add(new Worker("Tsekov", "Sifonav", 280,1.8));
            workerList.Add(new Worker("Emsiv", "Faraonav", 295,3));
            workerList.Add(new Worker("Ivana", "Jeleva", 385,2.2));
            workerList.Add(new Worker("BJq", "Pennq", 459,3.2));
            workerList.Add(new Worker("Them", "RealDeala", 560,6));
            workerList.Add(new Worker("Geshko", "Geshkev", 1000,5));

            var workerDescending = workerList.OrderByDescending(worker => worker.Money);

            foreach (var element in workerDescending)
            {
                Console.WriteLine(" {0} {1}", element.FullName(), element.Money);
            }

            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine();

            var result1 = from student in studentList
                                  select new { student.Firstname, student.Lastname };

            var result2 = from worker in workerList
                          select new { worker.Firstname, worker.Lastname };

            var finalResult = result1.Concat(result2);

            var finalResultOrderedByFirstName = finalResult.OrderBy(first => first.Firstname);

            foreach (var element in finalResultOrderedByFirstName)
            {
                Console.WriteLine(" {0}", element);
            }

            Console.WriteLine();

            var finalResultOrderedByLastName = finalResult.OrderBy(first => first.Lastname);

            foreach (var element in finalResultOrderedByLastName)
            {
                Console.WriteLine(" {0}", element);
            }

        }
    }
}
