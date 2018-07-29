using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class EmailAddresses
    {
        public string Id { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddressCaps { get; set; }
        public sbyte? InvalidEmail { get; set; }
        public sbyte? OptOut { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
