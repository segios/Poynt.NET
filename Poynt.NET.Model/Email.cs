
using System;

namespace Poynt.NET.Model
{

    public class Email

    {

        private const string TAG = "Email";

        public bool? Primary { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public EmailStatus Status { get; set; }

        public EmailType Type { get; set; }

        public long? Id { get; set; }

        public string EmailAddress { get; set; }

    }
}
