using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Versions
    {
        public string Id { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string FileVersion { get; set; }
        public string DbVersion { get; set; }
    }
}
