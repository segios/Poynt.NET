
using System;

namespace Poynt.NET.Model
{

    public class Address

    {

        private const string TAG = "Address";

        public AddressStatus Status { get; set; }

        public AddressType Type { get; set; }

        public bool? Primary { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public long? Id { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string Territory { get; set; }

        public string PostalCode { get; set; }

        public string PostalCodeExtension { get; set; }

        public string CountryCode { get; set; } = "USA";

        public TerritoryType TerritoryType { get; set; }
    }
}
