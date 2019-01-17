using System;
using System.Collections.Generic;
using System.Text;

namespace WebSIS.BL.Models
{
   public class DepartmentModel
    {
        public DepartmentModel()
        {
            Courses = new List<CourseModel>();
            Students = new List<StudentModel>();
            Teachers = new List<TeacherModel>();
        }

        public Guid Id { get; set; }
        public string EnName { get; set; }
        public string ArName { get; set; }
        public string Code { get; set; }
        public Guid CategoryId { get; set; }
        public IEnumerable<CourseModel> Courses { get; set; }
        public IEnumerable<StudentModel> Students { get; set; }
        public IEnumerable<TeacherModel> Teachers { get; set; }
    }
}
