using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string CustName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int? PaymentModeId { get; set; }
        public bool? IsDelivered { get; set; }
        public int? RatingId { get; set; }
        public string Feedback { get; set; }
        public int? InvoiceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
        public int? RestaurantId { get; set; }
    }
}
