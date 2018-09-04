//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Variant
	
	{
	
	private const string TAG = "Variant";
	
	public bool? DefaultVariant { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public CurrencyAmount Price { get; set; }
	
	public IList<Inventory> Inventory { get; set; }
	
	public IList<ProductVariation> Variations { get; set; }
	
	public IList<SelectableVariation> SelectableVariations { get; set; }
	
	public string Sku { get; set; }
	   
    }
}
