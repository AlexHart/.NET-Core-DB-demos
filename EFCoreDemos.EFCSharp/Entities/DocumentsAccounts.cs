using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class DocumentsAccounts
    {
        public string Id { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
        public string DocumentId { get; set; }
        public string AccountId { get; set; }
    }
}
