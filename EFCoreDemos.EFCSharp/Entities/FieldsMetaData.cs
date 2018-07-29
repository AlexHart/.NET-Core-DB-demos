using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class FieldsMetaData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Vname { get; set; }
        public string Comments { get; set; }
        public string Help { get; set; }
        public string CustomModule { get; set; }
        public string Type { get; set; }
        public int? Len { get; set; }
        public sbyte? Required { get; set; }
        public string DefaultValue { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte? Deleted { get; set; }
        public sbyte? Audited { get; set; }
        public sbyte? Massupdate { get; set; }
        public short? DuplicateMerge { get; set; }
        public sbyte? Reportable { get; set; }
        public string Importable { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
        public string Ext3 { get; set; }
        public string Ext4 { get; set; }
    }
}
