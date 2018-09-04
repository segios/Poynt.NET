//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{
	 
	public class ErrorInfo
	
	{
	
	private const string TAG = "ErrorInfo";
	
	public Code Code { get; set; }
	
	public int? HttpStatus { get; set; }
	
	public string Message { get; set; }
	
	public string DeveloperMessage { get; set; }
	
	public string MoreInfo { get; set; }
	
	public string RequestId { get; set; }
	   
    }
}
