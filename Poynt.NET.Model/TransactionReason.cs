using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{
	 
	public class TransactionReason
	
	{
	
	private const string TAG = "TransactionReason";
	
	public IList<TransactionReasonProgramFor> ProgramFor { get; set; }
	
	public TransactionReasonProgram Program { get; set; }
	   
    }
}
