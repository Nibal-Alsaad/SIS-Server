using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class Students
    {
        public Students()
        {
            Attendence = new HashSet<Attendence>();
            BlackList = new HashSet<BlackList>();
            WaitingList = new HashSet<WaitingList>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullEnName { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Idnumber { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Guid DepartmentId { get; set; }
        public bool? IsStudent { get; set; }
        public int Code { get; set; }
        public DateTime UniversityRegistrationDate { get; set; }

        public Departments Department { get; set; }
        public ICollection<Attendence> Attendence { get; set; }
        public ICollection<BlackList> BlackList { get; set; }
        public ICollection<WaitingList> WaitingList { get; set; }
    }
}
