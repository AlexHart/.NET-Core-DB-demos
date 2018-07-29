﻿using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class AclRolesActions
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string ActionId { get; set; }
        public int? AccessOverride { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
