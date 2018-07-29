using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class RolesModules
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string ModuleId { get; set; }
        public sbyte? Allow { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
