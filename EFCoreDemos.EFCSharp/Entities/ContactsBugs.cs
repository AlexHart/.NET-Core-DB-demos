using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ContactsBugs
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string BugId { get; set; }
        public string ContactRole { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
