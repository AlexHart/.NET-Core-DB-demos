using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class LinkedDocuments
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string ParentType { get; set; }
        public string DocumentId { get; set; }
        public string DocumentRevisionId { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
