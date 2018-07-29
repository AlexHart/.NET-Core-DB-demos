using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Currencies
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Iso4217 { get; set; }
        public double? ConversionRate { get; set; }
        public string Status { get; set; }
        public sbyte? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string CreatedBy { get; set; }
    }
}
