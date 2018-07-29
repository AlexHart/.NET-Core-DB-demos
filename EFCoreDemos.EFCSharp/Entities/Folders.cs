using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Folders
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FolderType { get; set; }
        public string ParentFolder { get; set; }
        public sbyte? HasChild { get; set; }
        public sbyte? IsGroup { get; set; }
        public sbyte? IsDynamic { get; set; }
        public string DynamicQuery { get; set; }
        public string AssignToId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
