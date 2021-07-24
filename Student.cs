using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents individual student
    /// </summary>
    class Student
    {
        /// <summary>
        /// Legal first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Legal last name
        /// </summary>
        public string LastName { get; set; }

        public List<Course> Schedule { get; set; }
    }
}
