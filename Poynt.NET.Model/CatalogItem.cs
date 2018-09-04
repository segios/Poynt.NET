using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CatalogItem

    {

        private const string TAG = "CatalogItem";

        public int? DisplayOrder { get; set; }

        public IList<AvailableDiscount> AvailableDiscounts { get; set; }

        public IList<Tax> Taxes { get; set; }

        public string Id { get; set; }

        public string Color { get; set; }

    }
}
