using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectConsole.DTO
{
    /// <summary>
    /// All data contining to a course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// The unique id of the course
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Id of the course template
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// The start date of the course
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the course
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The semester the course is taught
        /// </summary>
        public string Semester { get; set; }

        /// <summary>
        /// The maximum number of students allowed in the course
        /// </summary>
        public int MaxStudent { get; set; }
    }
}
