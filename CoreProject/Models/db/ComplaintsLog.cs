using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class ComplaintsLog
    {
        public int Id { get; set; }
        public int? ComplaintsId { get; set; }
        public string Descr { get; set; }
        public int? CustomerId { get; set; }
        public int? RestaurantId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
