using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class PermissionLog
    {
        public int Id { get; set; }
        public string Descr { get; set; }
        public int? RestaurantId { get; set; }
        public int? ReasonId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
