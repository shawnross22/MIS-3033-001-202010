using System;
using System.Collections.Generic;

namespace ClassesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student stud1 = new Student();
            stud1.setName("Shawn");
            stud1.id = 22;
            stud1.name = "Shawn";
            students.Add(stud1);

            Student stud2 = new Student("Shawn", 22);
            students.Add(stud2);

            Student stud3 = new Student("John", 1);
            students.Add(stud3);

            foreach (var stud in students)
            {
                
                Console.WriteLine(stud);
            }

            DateTime current = DateTime.Now;
            DateTime past = Convert.ToDateTime("4/7/1999");

            var result = current - past;
            Console.WriteLine($"It has been {result.TotalDays} since my birthday");

            TimeSpan difference = current - stud1.enrolldate;
            Console.WriteLine($" It has been {difference.TotalMilliseconds}ms since {stud1.name} has enrolled");

            Console.WriteLine($"There are currently {Student.totalStudents} enrolled"); 

            Console.ReadKey();
        }
    }
}
