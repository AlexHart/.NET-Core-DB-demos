using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ProjectsCases
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string ProjectId { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
