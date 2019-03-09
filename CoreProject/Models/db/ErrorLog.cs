using System;
using System.Collections.Generic;

namespace CoreProject.Models.db
{
    public partial class ErrorLog
    {
        public int Id { get; set; }
        public string Descr { get; set; }
        public string Params { get; set; }
        public int? Userid { get; set; }
        public string Browser { get; set; }
        public string Os { get; set; }
        public string Weburl { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
