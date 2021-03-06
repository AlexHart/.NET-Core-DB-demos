﻿using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class EmailsText
    {
        public string EmailId { get; set; }
        public string FromAddr { get; set; }
        public string ReplyToAddr { get; set; }
        public string ToAddrs { get; set; }
        public string CcAddrs { get; set; }
        public string BccAddrs { get; set; }
        public string Description { get; set; }
        public string DescriptionHtml { get; set; }
        public string RawSource { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
