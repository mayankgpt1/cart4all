using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class Categories
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
