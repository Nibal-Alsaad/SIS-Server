using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class Departments
    {
        public Departments()
        {
            Courses = new HashSet<Courses>();
            Students = new HashSet<Students>();
            Teachers = new HashSet<Teachers>();
        }

        public Guid Id { get; set; }
        public string EnName { get; set; }
        public string ArName { get; set; }
        public string Code { get; set; }
        public Guid CategoryId { get; set; }

        public DepartmentsCategories Category { get; set; }
        public ICollection<Courses> Courses { get; set; }
        public ICollection<Students> Students { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
    }
}
