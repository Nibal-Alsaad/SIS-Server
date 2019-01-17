using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class Attendence
    {
        public Guid Id { get; set; }
        public Guid CourseLogId { get; set; }
        public Guid StudentId { get; set; }
        public decimal? AttendencePercent { get; set; }

        public CoursesLog CourseLog { get; set; }
        public Students Student { get; set; }
    }
}
