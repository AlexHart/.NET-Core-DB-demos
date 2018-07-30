using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Sugarfeed
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
        public string RelatedModule { get; set; }
        public string RelatedId { get; set; }
        public string LinkUrl { get; set; }
        public string LinkType { get; set; }
    }
}
