//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class StreamMessage
	
	{
	
	private const string TAG = "StreamMessage";
	
	public DateTime CreatedAt { get; set; }
	
	public string DeviceId { get; set; }
	
	public string SerialNum { get; set; }
	
	public string Type { get; set; }
	
	public string Body { get; set; }
	
	public System.Guid businessId;
	
	public System.Guid storeId;
	   
    }
}
