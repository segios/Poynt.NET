using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class BusinessUser

    {

        private const string TAG = "BusinessUser";

        public BusinessUserStatus Status { get; set; }

        public EmploymentDetails EmploymentDetails { get; set; }

        public IList<Card> Cards { get; set; }

        public IList<UserCredential> Credentials { get; set; }

        public long? UserId { get; set; }

        public long? StartDate { get; set; }

        public long? EndDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string MiddleInitial { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }

        public string EmailSignupCode { get; set; }

        public System.Guid businessId { get; set; }

    }
}
