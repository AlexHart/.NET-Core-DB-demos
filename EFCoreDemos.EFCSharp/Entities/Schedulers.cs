using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Schedulers
    {
        public string Id { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedUserId { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public string JobInterval { get; set; }
        public TimeSpan? TimeFrom { get; set; }
        public TimeSpan? TimeTo { get; set; }
        public DateTime? LastRun { get; set; }
        public string Status { get; set; }
        public sbyte? CatchUp { get; set; }
    }
}
