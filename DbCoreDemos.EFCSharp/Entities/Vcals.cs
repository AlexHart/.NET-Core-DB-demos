using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Vcals
    {
        public string Id { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Content { get; set; }
    }
}
