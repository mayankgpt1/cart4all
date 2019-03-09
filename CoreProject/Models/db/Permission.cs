using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int? RestaurantId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
