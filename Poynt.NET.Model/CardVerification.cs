using System;

namespace Poynt.NET.Model
{

    public class CardVerification

    {

        private const string TAG = "CardVerification";

        public ClientContext Context { get; set; }

        public FundingSource FundingSource { get; set; }

        public ProcessorResponse ProcessorResponse { get; set; }

    }
}
