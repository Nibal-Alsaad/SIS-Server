using System;
using System.Collections.Generic;
using System.Text;

namespace WebSIS.BL.Models
{
   public class DepartmentCategoryModel
    {

        public DepartmentCategoryModel()
        {
            Departments = new List<DepartmentModel>();
        }

        public Guid Id { get; set; }
        public string ArName { get; set; }
        public string EnName { get; set; }
        public string Code { get; set; }

        public IEnumerable<DepartmentModel> Departments { get; set; }
    }
}
