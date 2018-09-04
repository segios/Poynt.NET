using System;

namespace Poynt.NET.Model
{

    public class EmploymentDetails

    {

        private const string TAG = "EmploymentDetails";

        public BusinessUserRole Role { get; set; }

        public long? StartAt { get; set; }

        public long? EndAt { get; set; }

    }
}
