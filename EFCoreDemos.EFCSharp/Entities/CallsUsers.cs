using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class CallsUsers
    {
        public string Id { get; set; }
        public string CallId { get; set; }
        public string UserId { get; set; }
        public string Required { get; set; }
        public string AcceptStatus { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
