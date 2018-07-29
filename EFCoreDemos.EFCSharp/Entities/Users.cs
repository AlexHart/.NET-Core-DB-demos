using System;
using System.Collections.Generic;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class Users
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string UserHash { get; set; }
        public sbyte? SystemGeneratedPassword { get; set; }
        public DateTime? PwdLastChanged { get; set; }
        public string AuthenticateId { get; set; }
        public sbyte? SugarLogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public sbyte? IsAdmin { get; set; }
        public sbyte? ExternalAuthOnly { get; set; }
        public sbyte? ReceiveNotifications { get; set; }
        public string Description { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneFax { get; set; }
        public string Status { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPostalcode { get; set; }
        public sbyte? Deleted { get; set; }
        public sbyte? PortalOnly { get; set; }
        public sbyte? ShowOnEmployees { get; set; }
        public string EmployeeStatus { get; set; }
        public string MessengerId { get; set; }
        public string MessengerType { get; set; }
        public string ReportsToId { get; set; }
        public sbyte? IsGroup { get; set; }
    }
}
