using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Representing a single college course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// The title of the course
        /// ex. Programming Fundamentals
        /// </summary>
        public string CourseTitle { get; set; }

        /// <summary>
        /// The text description of the course.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The unique course id assigned to the course
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// The number of college credits
        /// earned for completing the class
        /// </summary>
        public byte Credits { get; set; }
    }
}
