using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class Ratings
    {
        public int Id { get; set; }
        public int? Value { get; set; }
        public string Descr { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
