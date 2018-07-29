using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ProspectListCampaigns
    {
        public string Id { get; set; }
        public string ProspectListId { get; set; }
        public string CampaignId { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
