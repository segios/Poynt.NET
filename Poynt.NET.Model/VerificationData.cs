//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class VerificationData
	
	{
	
	private const string TAG = "VerificationData";
	
	public Address CardHolderBillingAddress { get; set; }
	
	public CVSkipReason CvSkipReason { get; set; }
	
	public IdType AdditionalIdType { get; set; }
	
	public string CvData { get; set; }
	
	public string AdditionalIdRefNumber { get; set; }
	
	public string Pin { get; set; }
	
	public string KeySerialNumber { get; set; }
	   
    }
}
