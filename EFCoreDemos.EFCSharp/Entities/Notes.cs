using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Notes
    {
        public string AssignedUserId { get; set; }
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string FileMimeType { get; set; }
        public string Filename { get; set; }
        public string ParentType { get; set; }
        public string ParentId { get; set; }
        public string ContactId { get; set; }
        public sbyte? PortalFlag { get; set; }
        public sbyte? EmbedFlag { get; set; }
        public string Description { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
