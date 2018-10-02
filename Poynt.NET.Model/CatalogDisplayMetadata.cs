
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CatalogDisplayMetadata
    {

        private const string TAG = "CatalogDisplayMetadata";
        public int NumberOfColumns { get; set; }
        public int NumberOfRows { get; set; }

        public string OptimizedForPackage { get; set; }

        public string VerticalScroll { get; set; }

        public string HorizontalScroll { get; set; }
    }
}
