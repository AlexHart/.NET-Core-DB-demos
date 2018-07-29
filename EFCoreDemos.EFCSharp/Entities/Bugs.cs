using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Bugs
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public sbyte? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public int BugNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Resolution { get; set; }
        public string WorkLog { get; set; }
        public string FoundInRelease { get; set; }
        public string FixedInRelease { get; set; }
        public string Source { get; set; }
        public string ProductCategory { get; set; }
    }
}
