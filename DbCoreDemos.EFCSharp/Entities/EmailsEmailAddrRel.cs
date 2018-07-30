using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class EmailsEmailAddrRel
    {
        public string Id { get; set; }
        public string EmailId { get; set; }
        public string AddressType { get; set; }
        public string EmailAddressId { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
