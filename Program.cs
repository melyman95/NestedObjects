using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor Derp = new Instructor()
            {
                FullName = "Peter Griffin",
                Email = "FatGuy@cptc.edu"
            };

            Student student = new Student()
            {
                FirstName = "Joe",
                LastName = "Blow",
            };

            Student student2 = new Student()
            {
                FirstName = "Mickey",
                LastName = "Mouse"
            };

            Student student3 = new Student()
            {
                FirstName = "Britney",
                LastName = "Spears"
            };

            Course CPW212 = new Course();
            CPW212.Title = "CPW 212 - Adv .NET";
            CPW212.Description = "More .NET";
            CPW212.Credits = 5;
            CPW212.CourseInstructor = Derp;
            CPW212.ClassRoster = new List<Student>();
            // Add students to course
            CPW212.ClassRoster.Add(student);
            CPW212.ClassRoster.Add(student2);
            CPW212.ClassRoster.Add(student3);

            Course CPW213 = new Course();
            CPW213.Title = "CPW 213 - .NET Web Programming";
            CPW213.Description = "Making websites with .NET";
            CPW213.Credits = 5;
            CPW213.CourseInstructor = Derp;
            CPW213.ClassRoster = new List<Student>();
            CPW213.ClassRoster.Add(student);
            CPW213.ClassRoster.Add(student2);
            CPW213.ClassRoster.Add(student3);

            Course CPW245 = new Course();
            CPW245.Title = "CPW 245 Data and Logic Structures";
            CPW245.Description = "Use data and logic structures to solve programming problems.";
            CPW245.Credits = 5;
            CPW245.CourseInstructor = Derp;
            CPW245.ClassRoster = new List<Student>();
            CPW245.ClassRoster.Add(student);
            CPW245.ClassRoster.Add(student2);
            CPW245.ClassRoster.Add(student3);

            student.Schedule = new List<Course>();
            student2.Schedule = new List<Course>();
            student3.Schedule = new List<Course>();

            student.Schedule.Add(CPW212);
            student2.Schedule.Add(CPW212);
            student3.Schedule.Add(CPW212);

            student.Schedule.Add(CPW213);
            student2.Schedule.Add(CPW213);
            student3.Schedule.Add(CPW213);

            student.Schedule.Add(CPW245);
            student2.Schedule.Add(CPW245);
            student3.Schedule.Add(CPW245);

            Console.WriteLine(CPW212.Title);
            Console.WriteLine("is taught by " + CPW212.CourseInstructor.FullName);

            Console.WriteLine("Currently enrolled students: ");
            foreach(Student s in CPW212.ClassRoster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }

            Console.WriteLine();
            Console.WriteLine(student.FirstName + student.LastName + "'s schedule: " );

            foreach(Course c in student.Schedule)
            {
                Console.WriteLine(c.Title);
            }

            Console.WriteLine();
            Console.WriteLine(student2.FirstName + student2.LastName + "'s schedule: ");

            foreach (Course c in student2.Schedule)
            {
                Console.WriteLine(c.Title);
            }

            Console.WriteLine();
            Console.WriteLine(student3.FirstName + student3.LastName + "'s schedule: ");

            foreach (Course c in student3.Schedule)
            {
                Console.WriteLine(c.Title);
            }
            Console.ReadKey();
        }
    }
}
