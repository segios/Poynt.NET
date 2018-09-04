//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class Phone
	
	{
	
	private const string TAG = "Phone";
	
	public bool? PrimaryDayTime { get; set; }
	
	public bool? PrimaryEvening { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public long? Id { get; set; }
	
	public PhoneStatus Status { get; set; }
	
	public PhoneType Type { get; set; }
	
	public string ItuCountryCode { get; set; }
	
	public string AreaCode { get; set; }
	
	public string LocalPhoneNumber { get; set; }
	
	public string ExtensionNumber { get; set; }
	   
    }
}
