//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class ProcessorResponse
	
	{
	
	private const string TAG = "ProcessorResponse";
	
	public AVSResult AvsResult { get; set; }
	
	public CVResult CvResult { get; set; }
	
	public long? RemainingBalance { get; set; }
	
	public long? ApprovedAmount { get; set; }
	
	public IDictionary<string, string> EmvTags { get; set; }
	
	public Processor Processor { get; set; }
	
	public Processor Acquirer { get; set; }
	
	public ProcessorStatus Status { get; set; }
	
	public ProviderVerification ProviderVerification { get; set; }
	
	public string StatusCode { get; set; }
	
	public string StatusMessage { get; set; }
	
	public string TransactionId { get; set; }
	
	public string ApprovalCode { get; set; }
	
	public string BatchId { get; set; }
	
	public string RetrievalRefNum { get; set; }
	
	public string CardToken { get; set; }
	
	public string CvActualResult { get; set; }
	   
    }
}
