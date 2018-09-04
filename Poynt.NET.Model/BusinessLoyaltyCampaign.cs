using System;

namespace Poynt.NET.Model
{

    public class BusinessLoyaltyCampaign

    {

        private const string TAG = "BusinessLoyaltyCampaign";

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime StartOn { get; set; }

        public DateTime EndOn { get; set; }

        public long? Id { get; set; }

        public long? BusinessId { get; set; }

        public long? StoreId { get; set; }

        public string Name { get; set; }

        public string DescCampaign { get; set; }

        public string LoyaltyType { get; set; }

        public string LoyaltyConfig { get; set; }

        public string RewardDescription { get; set; }

    }
}
