using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        /// <summary>
        /// Title of the course
        /// Ex. CPW 212 - Advanced .NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Official course description from the catalog
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Number of college credits awarded for passing this course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// Instructor that teaches the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }

        /// <summary>
        /// List of students that are enrolled in the class
        /// </summary>
        public List<Student> ClassRoster { get; set; }
    }
}
