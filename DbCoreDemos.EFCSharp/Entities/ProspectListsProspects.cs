﻿using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class ProspectListsProspects
    {
        public string Id { get; set; }
        public string ProspectListId { get; set; }
        public string RelatedId { get; set; }
        public string RelatedType { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
