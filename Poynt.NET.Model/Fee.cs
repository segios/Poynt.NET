using System;

namespace Poynt.NET.Model
{
	 
	public class Fee
	
	{
	
	private const string TAG = "Fee";
	
	public float? Percentage { get; set; }
	
	public long? Id { get; set; }
	
	public long? Amount { get; set; }
	
	public string Name { get; set; }
	   
    }
}
