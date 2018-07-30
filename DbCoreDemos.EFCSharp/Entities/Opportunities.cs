using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Opportunities
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public sbyte? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public string OpportunityType { get; set; }
        public string CampaignId { get; set; }
        public string LeadSource { get; set; }
        public double? Amount { get; set; }
        public double? AmountUsdollar { get; set; }
        public string CurrencyId { get; set; }
        public DateTime? DateClosed { get; set; }
        public string NextStep { get; set; }
        public string SalesStage { get; set; }
        public double? Probability { get; set; }
    }
}
