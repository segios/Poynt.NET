
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class Catalog

    {

        private const string TAG = "Catalog";

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public IList<AvailableDiscount> AvailableDiscounts { get; set; }

        public IList<CatalogItem> Products { get; set; }

        public IList<Category> Categories { get; set; }

        public IList<Tax> Taxes { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string PriceBookId { get; set; }

        public System.Guid businessId { get; set; }
    }
}
