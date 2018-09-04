//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class TerminalId
	
	{
	
	private const string TAG = "TerminalId";
	
	public Business Business { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public DateTime ActivatedAt { get; set; }
	
	public IDictionary<BusinessAgreementType, BusinessAgreement> BusinessAgreements { get; set; }
	
	public IDictionary<string, string> Properties { get; set; }
	
	public Processor Acquirer { get; set; }
	
	public Processor Processor { get; set; }
	
	public Store Store { get; set; }
	
	public string Tid { get; set; }
	
	public string Mid { get; set; }
	
	public string DeviceId { get; set; }
	
	public string DeviceSerial { get; set; }
	
	public string DeviceName { get; set; }
	
	public string CatalogId { get; set; }
	
	public System.Guid id;
	   
    }
}
