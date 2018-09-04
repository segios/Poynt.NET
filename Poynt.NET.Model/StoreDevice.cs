//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class StoreDevice
	
	{
	
	private const string TAG = "StoreDevice";
	
	public DateTime LastSeenAt { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public IList<DeviceKekData> KekDetails { get; set; }
	
	public long? _id { get; set; }
	
	public IDictionary<BusinessAgreementType, BusinessAgreement> BusinessAgreements { get; set; }
	
	public IDictionary<string, string> ProcessorData { get; set; }
	
	public PublicKeyVerificationData PublicKeyVerification { get; set; }
	
	public StoreDeviceStatus Status { get; set; }
	
	public StoreDeviceType Type { get; set; }
	
	public string ExternalTerminalId { get; set; }
	
	public string DeviceId { get; set; }
	
	public string SerialNumber { get; set; }
	
	public string Name { get; set; }
	
	public string PublicKey { get; set; }
	
	public string CatalogId { get; set; }
	
	public System.Guid storeId;
	   
    }
}
