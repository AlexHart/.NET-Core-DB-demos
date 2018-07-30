using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class UsersSignatures
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Signature { get; set; }
        public string SignatureHtml { get; set; }
    }
}
