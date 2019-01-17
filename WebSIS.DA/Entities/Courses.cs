using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class Courses
    {
        public Courses()
        {
            CoursesLog = new HashSet<CoursesLog>();
        }

        public Guid Id { get; set; }
        public string EnName { get; set; }
        public string ArName { get; set; }
        public Guid CategoryId { get; set; }
        public Guid DepartmentId { get; set; }

        public CoursesCategories Category { get; set; }
        public Departments Department { get; set; }
        public ICollection<CoursesLog> CoursesLog { get; set; }
    }
}
