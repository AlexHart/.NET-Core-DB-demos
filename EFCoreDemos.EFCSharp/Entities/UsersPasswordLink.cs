using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class UsersPasswordLink
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public DateTime? DateGenerated { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
