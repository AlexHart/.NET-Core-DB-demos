using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ProspectLists
    {
        public string AssignedUserId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ListType { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public sbyte? Deleted { get; set; }
        public string Description { get; set; }
        public string DomainName { get; set; }
    }
}
