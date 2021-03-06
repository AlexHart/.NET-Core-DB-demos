﻿using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Relationships
    {
        public string Id { get; set; }
        public string RelationshipName { get; set; }
        public string LhsModule { get; set; }
        public string LhsTable { get; set; }
        public string LhsKey { get; set; }
        public string RhsModule { get; set; }
        public string RhsTable { get; set; }
        public string RhsKey { get; set; }
        public string JoinTable { get; set; }
        public string JoinKeyLhs { get; set; }
        public string JoinKeyRhs { get; set; }
        public string RelationshipType { get; set; }
        public string RelationshipRoleColumn { get; set; }
        public string RelationshipRoleColumnValue { get; set; }
        public sbyte? Reverse { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
