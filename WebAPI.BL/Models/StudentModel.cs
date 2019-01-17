using System;
using System.Collections.Generic;
using System.Text;

namespace WebSIS.BL.Models
{
  public class StudentModel
    {
        public StudentModel()
        {
            Attendence = new List<AttendenceModel>();
            BlackList = new List<BlackListModel>();
            WaitingList = new List<WaitingListModel>();
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

        public DepartmentModel Department { get; set; }
        public IEnumerable<AttendenceModel> Attendence { get; set; }
        public IEnumerable<BlackListModel> BlackList { get; set; }
        public IEnumerable<WaitingListModel> WaitingList { get; set; }
    }
}
