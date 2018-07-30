using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class OauthNonce
    {
        public string Conskey { get; set; }
        public string Nonce { get; set; }
        public long? NonceTs { get; set; }
    }
}
