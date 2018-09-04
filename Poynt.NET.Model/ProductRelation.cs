using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class ProductRelation
	
	{
	
	private const string TAG = "ProductRelation";
	
	public CurrencyAmount Price { get; set; }
	
	public IList<string> RelatedProductSku { get; set; }
	
	public long? Count { get; set; }
	
	public ProductRelationType Type { get; set; }
	
	public string RelatedProductId { get; set; }
	   
    }
}
