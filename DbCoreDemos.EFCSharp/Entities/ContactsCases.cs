using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ContactsCases
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string CaseId { get; set; }
        public string ContactRole { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
