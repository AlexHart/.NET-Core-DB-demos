﻿using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Tasks
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
        public string Status { get; set; }
        public sbyte? DateDueFlag { get; set; }
        public DateTime? DateDue { get; set; }
        public sbyte? DateStartFlag { get; set; }
        public DateTime? DateStart { get; set; }
        public string ParentType { get; set; }
        public string ParentId { get; set; }
        public string ContactId { get; set; }
        public string Priority { get; set; }
    }
}
