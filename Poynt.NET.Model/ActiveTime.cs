
using System;

namespace Poynt.NET.Model
{

    public class ActiveTime

    {

        private const string TAG = "ActiveTime";

        public bool? Repeat { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public long? StartHour { get; set; }

        public long? EndHour { get; set; }

        public RepeatType RepeatType { get; set; }

        public long[] every { get; set; }

    }
}
