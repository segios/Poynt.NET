//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{

    public class FundingSource

    {

        private const string TAG = "FundingSource";

        public bool? Debit { get; set; }

        public Card Card { get; set; }

        public CustomFundingSource CustomFundingSource { get; set; }

        public DebitEBTReEntry DebitEBTReEntryDetails { get; set; }

        public EBTDetails EbtDetails { get; set; }

        public EMVData EmvData { get; set; }

        public ExchangeRate ExchangeRate { get; set; }

        public FundingSourceAccountType AccountType { get; set; }

        public FundingSourceEntryDetails EntryDetails { get; set; }

        public FundingSourceType Type { get; set; }

        public string InteracMac { get; set; }

        public VerificationData VerificationData { get; set; }

    }
}
