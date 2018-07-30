using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class OpportunitiesContacts
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string OpportunityId { get; set; }
        public string ContactRole { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
