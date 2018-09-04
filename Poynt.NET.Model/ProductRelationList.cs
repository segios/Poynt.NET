using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class ProductRelationList
	
	{
	
	private const string TAG = "ProductRelationList";
	
	public IList<ProductRelation> Relations { get; set; }
	
	public long? Count { get; set; }
	   
    }
}
