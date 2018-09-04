
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public class Customer

    {

        private const string TAG = "Customer";

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public CustomerBusinessPreferences BusinessPreferences { get; set; }

        public CustomerInsights Insights { get; set; }

        public IList<Card> Cards { get; set; }

        public IList<Device> Devices { get; set; }

        public IList<LoyaltyCustomer> LoyaltyCustomers { get; set; }

        public long? Id { get; set; }

        public IDictionary<AddressType, Address> Addresses { get; set; }

        public IDictionary<EmailType, Email> Emails { get; set; }

        public IDictionary<PhoneType, Phone> Phones { get; set; }

        public IDictionary<string, string> Attributes { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string MiddleInitial { get; set; }

        public string NickName { get; set; }

        public System.Guid businessId { get; set; }

    }
}
