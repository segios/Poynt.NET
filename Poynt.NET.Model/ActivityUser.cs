using System;

namespace Poynt.NET.Model
{
    public class ActivityUser
    {

        private const string TAG = "ActivityUser";

        public ActivityAction Action { get; set; }

        public ActivitySource Source { get; set; }

        // todo link to serilize
        public ActivityUser ActivityUserRef { get; set; }

        public ActivityUserType Type { get; set; }

        public decimal Rating { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Gender Gender { get; set; }

        public long? Id { get; set; }

        public long? MatchingCustomerUserId { get; set; }

        public string ExternalId { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string ScreenName { get; set; }

        public string PhotoUrl { get; set; }

        public string HomeCity { get; set; }

        public TextSentiment Sentiment { get; set; }

    }
}
