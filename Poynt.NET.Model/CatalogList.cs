using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CatalogList

    {

        private const string TAG = "CatalogList";

        public IList<Catalog> Catalogs { get; set; }

        public IList<Link> Links { get; set; }

    }
}
