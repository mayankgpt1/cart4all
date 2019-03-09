using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public byte[] PassCode { get; set; }
        public string PanCard { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Emailid1 { get; set; }
        public string Emailid2 { get; set; }
        public string AadharCard { get; set; }
        public string Paytm1 { get; set; }
        public string Paytm2 { get; set; }
        public int? RoleId { get; set; }
        public bool? IsClient { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
