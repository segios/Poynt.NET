//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Product
	
	{
	
	private const string TAG = "Product";
	
	public DateTime ReleaseDate { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public CurrencyAmount Msrp { get; set; }
	
	public CurrencyAmount Price { get; set; }
	
	public CurrencyAmount AvgUnitCost { get; set; }
	
	public IList<Inventory> Inventory { get; set; }
	
	public IList<ProductRelation> BundledProducts { get; set; }
	
	public IList<ProductRelation> AddonProducts { get; set; }
	
	public IList<ProductRelation> RelatedProducts { get; set; }
	
	public IList<string> TemplateOverrides { get; set; }
	
	public IList<string> ImageUrl { get; set; }
	
	public IList<Tax> Taxes { get; set; }
	
	public IList<Variant> Variants { get; set; }
	
	public IList<Variant> SelectableVariants { get; set; }
	
	public IList<Variation> PossibleVariations { get; set; }
	
	public ProductStatus Status { get; set; }
	
	public ProductType Type { get; set; }
	
	public string Ean { get; set; }
	
	public string Upc { get; set; }
	
	public string Isbn { get; set; }
	
	public string Plu { get; set; }
	
	public string Asin { get; set; }
	
	public string ShortCode { get; set; }
	
	public string Name { get; set; }
	
	public string Description { get; set; }
	
	public string Specification { get; set; }
	
	public string Brand { get; set; }
	
	public string Manufacturer { get; set; }
	
	public string Publisher { get; set; }
	
	public string Studio { get; set; }
	
	public string Designer { get; set; }
	
	public string Author { get; set; }
	
	public string Artist { get; set; }
	
	public string Tags { get; set; }
	
	public string Id { get; set; }
	
	public string ProductTemplateId { get; set; }
	
	public string Sku { get; set; }
	
	public string Mpn { get; set; }
	
	public string StyleNumber { get; set; }
	
	public string ModelNumber { get; set; }
	
	public System.Guid businessId;
	
	public UnitOfMeasure UnitOfMeasure { get; set; }
	   
    }
}
