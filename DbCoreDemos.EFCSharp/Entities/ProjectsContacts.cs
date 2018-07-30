using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ProjectsContacts
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string ProjectId { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
