using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class Teachers
    {
        public Teachers()
        {
            CourseLogsTeachers = new HashSet<CourseLogsTeachers>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullEnName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public bool IsStudent { get; set; }
        public Guid DepartmentId { get; set; }
        public string Education { get; set; }
        public string Courses { get; set; }
        public string Degrees { get; set; }
        public string WorkExperience { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Code { get; set; }
        public bool? IsActive { get; set; }

        public Departments Department { get; set; }
        public ICollection<CourseLogsTeachers> CourseLogsTeachers { get; set; }
    }
}
