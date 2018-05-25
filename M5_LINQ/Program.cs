using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studList = new List<Student>
            {
                new Student{ FirstName = "Ahmed", LastName = "SalamShalam", Tel = "12345678901", Email = "Salam@gmail.com", Marks = new List<int>{ 5, 4, 3 }, GroupNumber = "STU-02-84" },
                new Student{ FirstName = "Abragim", LastName = "Sulubani",  Tel = "45645697801", Email = "Abragim@gmail.com", Marks = new List<int>{ 5,5,5 }, GroupNumber = "STU-02-84" },
                new Student{ FirstName = "Ivan", LastName = "Ivanov", Tel = "987464532105", Email = "iva@gmail.com", Marks = new List<int>{ 2,3,5 }, GroupNumber = "2" },
                new Student{ FirstName = "Sergey", LastName = "Pupkin", Tel = "12345678901", Email = "Pupok@gmail.com", Marks = new List<int>{ 4, 4, 3 }, GroupNumber = "2" },
                new Student{ FirstName = "Vasya", LastName = "Hrapkin", Tel = "55556666777", Email = "Hrapun@gmail.com", Marks = new List<int>{ 2, 4, 3 }, GroupNumber = "2" }
            };

            // LINQ
            var groupTwoLINQ =
                from stud in studList
                where stud.GroupNumber == "2"
                orderby stud.FirstName
                select stud;

            // Extension methods
            var groupTwoEx = studList.Where(n => n.GroupNumber == "2").OrderBy(n => n.FirstName);

            // Simple C#
            var groupTwoSimple = new List<Student>();
            foreach (var stud in studList)
            {
                if (stud.GroupNumber == "2")
                    groupTwoSimple.Add(stud);
            }

            groupTwoSimple.Sort();

            // Display all students
            Console.WriteLine("***All Students");
            Display(studList);
            Console.WriteLine("***Students LINQ");
            Display(groupTwoLINQ);

            Console.WriteLine("***Students Extension methods");
            Display(groupTwoEx);

            Console.WriteLine("***Students Simple C#");
            Display(groupTwoSimple);
        }

        public static void Display<T>(IEnumerable<T> array) where T : Student
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.FirstName + ' ' + item.LastName + ' ' + item.GroupNumber);
            }
        }
    }
}
