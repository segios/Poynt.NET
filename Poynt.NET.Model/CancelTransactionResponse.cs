using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CancelTransactionResponse

    {

        private const string TAG = "CancelTransactionResponse";

        public IList<CancelDetails> Transactions { get; set; }

    }
}
