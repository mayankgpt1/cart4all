using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class Restaurants
    {
        public int Id { get; set; }
        public string Descr { get; set; }
        public int? OwnerId { get; set; }
        public int? WebsiteId { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public string Landline1 { get; set; }
        public string Landline2 { get; set; }
        public string Landline3 { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
