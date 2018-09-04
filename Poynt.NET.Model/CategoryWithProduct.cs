
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
    public class CategoryWithProduct

    {

        private const string TAG = "CategoryWithProduct";

        public int? DisplayOrder { get; set; }

        public IList<AvailableDiscount> AvailableDiscounts { get; set; }

        public IList<CatalogItemWithProduct> Products { get; set; }

        public IList<Tax> Taxes { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string ParentCategoryId { get; set; }

        public string ShortCode { get; set; }

        public string Color { get; set; }

    }
}
