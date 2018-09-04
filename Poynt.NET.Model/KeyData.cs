using System;

namespace Poynt.NET.Model
{
	 
	public class KeyData
	
	{
	
	private const string TAG = "KeyData";
	
	public bool? Encrypted { get; set; }
	
	public Key Id { get; set; }
	
	public string Value { get; set; }
	
	public string Version { get; set; }
	   
    }
}
