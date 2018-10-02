using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CatalogItemWithProduct

    {

        private const string TAG = "CatalogItemWithProduct";

        public int? DisplayOrder { get; set; }

        public IList<AvailableDiscount> AvailableDiscounts { get; set; }

        public IList<CatalogDisplayMetadata> DisplayMetadata { get; set; }

        public IList<Tax> Taxes { get; set; }

        public Product Product { get; set; }

        public string Color { get; set; }

    }
}
