//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class UpdateStoreDeviceRequest
	
	{
	
	private const string TAG = "UpdateStoreDeviceRequest";
	
	public bool? NullSerialNumberAndDeviceId { get; set; }
	
	public bool? NullName { get; set; }
	
	public bool? NullCatalogId { get; set; }
	
	public Processor Acquirer { get; set; }
	
	public StoreDevice StoreDevice { get; set; }
	
	public string ExternalStoreId { get; set; }
	   
    }
}
