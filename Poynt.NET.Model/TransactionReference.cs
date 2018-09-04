using System;

namespace Poynt.NET.Model
{
	 
	public class TransactionReference
	
	{
	
	private const string TAG = "TransactionReference";
	
	public string Id { get; set; }
	
	public string CustomType { get; set; }
	
	public TransactionReferenceType Type { get; set; }
	   
    }
}
