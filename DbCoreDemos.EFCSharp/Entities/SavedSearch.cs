using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class SavedSearch
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SearchModule { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string AssignedUserId { get; set; }
        public string Contents { get; set; }
        public string Description { get; set; }
    }
}
