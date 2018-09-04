
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public class Application
    {

        private const string TAG = "Application";

        public ApplicationStatus Status { get; set; }

        public ApplicationType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public IList<ApplicationPermission> Permissions { get; set; }

        public string Id { get; set; }

        public string ApplicationUrn { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PublicKey { get; set; }

        public string PrivateKey { get; set; }

        public string Category { get; set; }

        public string WebsiteUrl { get; set; }

        public string Email { get; set; }

        public string PrivacyPolicyUrl { get; set; }

        public string ReturnUrl { get; set; }

        public string PackageName { get; set; }

        public System.Guid organizationId { get; set; }

    }
}
