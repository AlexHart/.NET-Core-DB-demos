using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class OauthTokens
    {
        public string Id { get; set; }
        public string Secret { get; set; }
        public string Tstate { get; set; }
        public string Consumer { get; set; }
        public long? TokenTs { get; set; }
        public string Verify { get; set; }
        public sbyte Deleted { get; set; }
        public string CallbackUrl { get; set; }
        public string AssignedUserId { get; set; }
    }
}
