using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class InboundEmailAutoreply
    {
        public string Id { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string AutorepliedTo { get; set; }
        public string IeId { get; set; }
    }
}
