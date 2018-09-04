//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class Transaction
	
	{
	
	private const string TAG = "Transaction";
	
	public bool? SignatureCaptured { get; set; }
	
	public bool? PinCaptured { get; set; }
	
	public bool? Adjusted { get; set; }
	
	public bool? AmountsAdjusted { get; set; }
	
	public bool? AuthOnly { get; set; }
	
	public bool? PartiallyApproved { get; set; }
	
	public bool? Voided { get; set; }
	
	public bool? Settled { get; set; }
	
	public DateTime CreatedAt { get; set; }
	
	public DateTime UpdatedAt { get; set; }
	
	public ClientContext Context { get; set; }
	
	public FundingSource FundingSource { get; set; }
	
	public IList<AdjustmentRecord> AdjustmentHistory { get; set; }
	
	public IList<Link> Links { get; set; }
	
	public IList<TransactionReference> References { get; set; }
	
	public long? _id { get; set; }
	
	public long? _parentId { get; set; }
	
	public long? CustomerUserId { get; set; }
	
	public Phone ReceiptPhone { get; set; }
	
	public PoyntLoyalty PoyntLoyalty { get; set; }
	
	public ProcessorResponse ProcessorResponse { get; set; }
	
	public StayType StayType { get; set; }
	
	public string TransactionNumber { get; set; }
	
	public string ReceiptEmailAddress { get; set; }
	
	public string Notes { get; set; }
	
	public string ApprovalCode { get; set; }
	
	public TransactionAction Action { get; set; }
	
	public TransactionAmounts Amounts { get; set; }
	
	public TransactionReason Reason { get; set; }
	
	public TransactionStatus Status { get; set; }
	
	public System.Guid id;
	
	public System.Guid parentId;
	
	public sbyte[] signature;
	   
    }
}
