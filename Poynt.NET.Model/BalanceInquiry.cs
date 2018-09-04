using System;

namespace Poynt.NET.Model
{

    public class BalanceInquiry

    {

        private const string TAG = "BalanceInquiry";

        public ClientContext Context { get; set; }

        public FundingSource FundingSource { get; set; }

        public ProcessorResponse ProcessorResponse { get; set; }

    }
}
