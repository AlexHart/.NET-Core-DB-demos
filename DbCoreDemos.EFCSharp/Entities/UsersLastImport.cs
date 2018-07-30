using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class UsersLastImport
    {
        public string Id { get; set; }
        public string AssignedUserId { get; set; }
        public string ImportModule { get; set; }
        public string BeanType { get; set; }
        public string BeanId { get; set; }
        public sbyte? Deleted { get; set; }
    }
}
