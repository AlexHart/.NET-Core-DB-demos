using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class EmailAddrBeanRel
    {
        public string Id { get; set; }
        public string EmailAddressId { get; set; }
        public string BeanId { get; set; }
        public string BeanModule { get; set; }
        public sbyte? PrimaryAddress { get; set; }
        public sbyte? ReplyToAddress { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
