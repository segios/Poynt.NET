using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CategoryList

    {

        private const string TAG = "CategoryList";

        public IList<Category> Categories { get; set; }

        public IList<Link> Links { get; set; }

    }
}
