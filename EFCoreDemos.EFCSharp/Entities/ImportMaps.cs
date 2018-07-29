using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ImportMaps
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Enclosure { get; set; }
        public string Delimiter { get; set; }
        public string Module { get; set; }
        public string Content { get; set; }
        public string DefaultValues { get; set; }
        public sbyte? HasHeader { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string AssignedUserId { get; set; }
        public string IsPublished { get; set; }
    }
}
