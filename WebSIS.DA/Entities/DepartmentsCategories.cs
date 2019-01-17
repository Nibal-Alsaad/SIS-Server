using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSIS.DA.Entities
{
    public partial class DepartmentsCategories
    {
        public DepartmentsCategories()
        {
            Departments = new HashSet<Departments>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string ArName { get; set; }
        public string EnName { get; set; }
        public string Code { get; set; }

        public ICollection<Departments> Departments { get; set; }
    }
}
