using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class TransactionList
	
	{
	
	private const string TAG = "TransactionList";
	
	public IList<Link> Links { get; set; }
	
	public IList<Transaction> Transactions { get; set; }
	
	public long? Count { get; set; }
	   
    }
}
