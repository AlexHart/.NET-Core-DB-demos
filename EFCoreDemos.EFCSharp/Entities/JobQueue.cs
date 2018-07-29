using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class JobQueue
    {
        public string AssignedUserId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string SchedulerId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public string Status { get; set; }
        public string Resolution { get; set; }
        public string Message { get; set; }
        public string Target { get; set; }
        public string Data { get; set; }
        public sbyte? Requeue { get; set; }
        public sbyte? RetryCount { get; set; }
        public sbyte? FailureCount { get; set; }
        public int? JobDelay { get; set; }
        public string Client { get; set; }
        public int? PercentComplete { get; set; }
    }
}
