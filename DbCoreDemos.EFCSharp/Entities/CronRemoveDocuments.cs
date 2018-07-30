using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class CronRemoveDocuments
    {
        public string Id { get; set; }
        public string BeanId { get; set; }
        public string Module { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
