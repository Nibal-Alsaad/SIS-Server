using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class CoursesLog
    {
        public CoursesLog()
        {
            Attendence = new HashSet<Attendence>();
            CourseLogsTeachers = new HashSet<CourseLogsTeachers>();
            WaitingList = new HashSet<WaitingList>();
        }

        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CourseId { get; set; }
        public bool IsDone { get; set; }

        public Courses Course { get; set; }
        public ICollection<Attendence> Attendence { get; set; }
        public ICollection<CourseLogsTeachers> CourseLogsTeachers { get; set; }
        public ICollection<WaitingList> WaitingList { get; set; }
    }
}
