using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class CoursesCategories
    {
        public CoursesCategories()
        {
            Courses = new HashSet<Courses>();
        }

        public Guid Id { get; set; }
        public string EnName { get; set; }
        public string ArName { get; set; }

        public ICollection<Courses> Courses { get; set; }
    }
}
