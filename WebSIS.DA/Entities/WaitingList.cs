using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class WaitingList
    {
        public Guid StudentId { get; set; }
        public Guid CourseLogId { get; set; }
        public DateTime SubscribetionDate { get; set; }

        public CoursesLog CourseLog { get; set; }
        public Students Student { get; set; }
    }
}
