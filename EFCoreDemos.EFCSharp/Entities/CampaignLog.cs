using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class CampaignLog
    {
        public string Id { get; set; }
        public string CampaignId { get; set; }
        public string TargetTrackerKey { get; set; }
        public string TargetId { get; set; }
        public string TargetType { get; set; }
        public string ActivityType { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string RelatedId { get; set; }
        public string RelatedType { get; set; }
        public sbyte? Archived { get; set; }
        public int? Hits { get; set; }
        public string ListId { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateModified { get; set; }
        public string MoreInformation { get; set; }
        public string MarketingId { get; set; }
    }
}
