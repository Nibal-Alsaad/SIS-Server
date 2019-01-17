using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class CourseLogsTeachers
    {
        public Guid Id { get; set; }
        public Guid CourseLogId { get; set; }
        public Guid TeacherId { get; set; }

        public CoursesLog CourseLog { get; set; }
        public Teachers Teacher { get; set; }
    }
}
