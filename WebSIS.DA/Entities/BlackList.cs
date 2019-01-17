using System;
using System.Collections.Generic;

namespace WebSIS.DA.Entities
{
    public partial class BlackList
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }

        public Students Student { get; set; }
    }
}
