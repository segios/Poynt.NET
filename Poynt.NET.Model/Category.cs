
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class Category

    {

        private const string TAG = "Category";

        public int? DisplayOrder { get; set; }

        public IList<AvailableDiscount> AvailableDiscounts { get; set; }

        public IList<CatalogItem> Products { get; set; }

        public IList<Tax> Taxes { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string ParentCategoryId { get; set; }

        public string ShortCode { get; set; }

        public string Color { get; set; }
    }
}
