using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class Users
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
