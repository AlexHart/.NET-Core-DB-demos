using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class UserPreferences
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string AssignedUserId { get; set; }
        public string Contents { get; set; }
    }
}
