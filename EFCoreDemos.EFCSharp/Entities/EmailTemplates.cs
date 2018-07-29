using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class EmailTemplates
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Published { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string BodyHtml { get; set; }
        public sbyte? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public sbyte? TextOnly { get; set; }
        public string Type { get; set; }
    }
}
