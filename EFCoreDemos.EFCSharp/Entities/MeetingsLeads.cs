using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class MeetingsLeads
    {
        public string Id { get; set; }
        public string MeetingId { get; set; }
        public string LeadId { get; set; }
        public string Required { get; set; }
        public string AcceptStatus { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
