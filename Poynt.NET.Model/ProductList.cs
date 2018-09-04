using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class ProductList
	
	{
	
	private const string TAG = "ProductList";
	
	public IList<Link> Links { get; set; }
	
	public IList<Product> Products { get; set; }
	   
    }
}
