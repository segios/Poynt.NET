using System;

namespace Poynt.NET.Model
{

    public class AvailableDiscount

    {

        private const string TAG = "AvailableDiscount";

        public ActiveTime When { get; set; }

        public DiscountScope Scope { get; set; }

        public DiscountType Type { get; set; }

        public float? Percentage { get; set; }

        public long? @fixed { get; set; }

        public string Code { get; set; }

        public string Id { get; set; }

    }
}
