using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public class Card

    {

        private const string TAG = "Card";

        public bool? Encrypted { get; set; }

        public CardType Type { get; set; }

        public FinancialInstrumentStatus Status { get; set; }

        public int? ExpirationDate { get; set; }

        public int? ExpirationMonth { get; set; }

        public int? ExpirationYear { get; set; }

        public IList<CardKeyData> Key { get; set; }

        public long? Id { get; set; }

        public string Number { get; set; }

        public string NumberFirst6 { get; set; }

        public string NumberLast4 { get; set; }

        public string NumberMasked { get; set; }

        public string NumberHashed { get; set; }

        public string CardHolderFirstName { get; set; }

        public string CardHolderLastName { get; set; }

        public string CardHolderFullName { get; set; }

        public string Currency { get; set; }

        public string Track1data { get; set; }

        public string Track2data { get; set; }

        public string Track3data { get; set; }

        public string KeySerialNumber { get; set; }

        public string SequenceNumber { get; set; }

        public string ServiceCode { get; set; }

        public string EncryptedExpirationDate { get; set; }

    }
}
