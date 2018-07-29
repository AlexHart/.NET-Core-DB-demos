using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class MeetingsContacts
    {
        public string Id { get; set; }
        public string MeetingId { get; set; }
        public string ContactId { get; set; }
        public string Required { get; set; }
        public string AcceptStatus { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
