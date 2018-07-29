using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ProjectsProducts
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string ProjectId { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
