using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CaptureAllResponse

    {

        private const string TAG = "CaptureAllResponse";

        public bool? ProcessingCloseBatch { get; set; }

        public IList<CaptureAllAccepted> AcceptedList { get; set; }

    }
}
