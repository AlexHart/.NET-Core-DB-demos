using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class AccountsContacts
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string AccountId { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
