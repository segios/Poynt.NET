
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public class CatalogWithProduct

    {

        private const string TAG = "CatalogWithProduct";

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public IList<AvailableDiscount> AvailableDiscounts { get; set; }

        public IList<CatalogItemWithProduct> Products { get; set; }

        public IList<CategoryWithProduct> Categories { get; set; }

        public IList<Tax> Taxes { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public System.Guid businessId { get; set; }
    }
}
