using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class CasesBugs
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string BugId { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
