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
                LastName = "Blow"
            };

            Student student2 = new Student()
            {
                FirstName = "Poo",
                LastName = "Pants"
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

            Console.WriteLine(CPW212.Title);
            Console.WriteLine("is taught by " + CPW212.CourseInstructor.FullName);

            Console.WriteLine("Currently enrolled students: ");
            foreach(Student s in CPW212.ClassRoster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
            Console.ReadKey();
        }
    }
}
