
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp20
{
    class Program
    {
        public static void Main(string[] args)
        {
            //___________________1___________________
            Task1();
            Task2();
            Task3();
        }



        public static void Task1()
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var q1_1 = numbers.Distinct().Order().ToList();
            foreach (var i in q1_1) { Console.WriteLine(i); }
            Console.WriteLine("=======================================");

            foreach (var i in q1_1) { Console.WriteLine($"<number:{i},multiplication:{i * i}>"); }
            Console.WriteLine("=======================================");
        }
        public static void Task2()
        {
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            var q1 = names.Where(name => name.Length == 3).ToList();
            foreach (var i in q1) { Console.WriteLine(i); }
            Console.WriteLine("=======================================");

            var q2 = names.Where(name=>name.ToLower().Contains('a')).OrderBy(n=>n.Length).ToList();
            foreach (var i in q2) { Console.WriteLine(i); }
            Console.WriteLine("=======================================");

            var q3 = names.Take(2).ToList();
            foreach (var i in q3) { Console.WriteLine(i); }
            Console.WriteLine("=======================================");

        }
        public static void Task3()
        {
            List<Student> students = new List<Student>()
        {
            new Student()
            {
                ID = 1,
                FirstName = "Ali",
                LastName = "Mohammed",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 33, Name = "UML" }
                }
            },
            new Student()
            {
                ID = 2,
                FirstName = "Mona",
                LastName = "Gala",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 34, Name = "XML" },
                    new Subject() { Code = 25, Name = "JS" }
                }
            },
            new Student()
            {
                ID = 3,
                FirstName = "Yara",
                LastName = "Yousf",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 25, Name = "JS" }
                }
            },
            new Student()
            {
                ID = 1,
                FirstName = "Ali",
                LastName = "Ali",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 33, Name = "UML" }
                }
            }
        };

            var q1 = students.Select(s => new { Full_name = s.FirstName + ' ' + s.LastName, num_subject = s.Subjects.Count() }).ToList();
            foreach(var i in q1) { Console.WriteLine($"<Full_name:{i.Full_name} , count:{i.num_subject}>"); }
            Console.WriteLine("=======================================");


            var q2 = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName).ToList();
            foreach (var i in q2){Console.WriteLine(i.FirstName + " " + i.LastName); }
             Console.WriteLine("=======================================");

        }
    }
}
