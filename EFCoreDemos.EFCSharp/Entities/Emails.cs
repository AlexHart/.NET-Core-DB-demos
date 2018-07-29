using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Emails
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string AssignedUserId { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateSent { get; set; }
        public string MessageId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public sbyte? Flagged { get; set; }
        public sbyte? ReplyToStatus { get; set; }
        public string Intent { get; set; }
        public string MailboxId { get; set; }
        public string ParentType { get; set; }
        public string ParentId { get; set; }
    }
}
