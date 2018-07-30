using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Tracker
    {
        public int Id { get; set; }
        public string MonitorId { get; set; }
        public string UserId { get; set; }
        public string ModuleName { get; set; }
        public string ItemId { get; set; }
        public string ItemSummary { get; set; }
        public DateTime? DateModified { get; set; }
        public string Action { get; set; }
        public string SessionId { get; set; }
        public sbyte? Visible { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
