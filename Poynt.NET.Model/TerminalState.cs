using System;

namespace Poynt.NET.Model
{
	 
	public class TerminalState
	
	{
	
	private const string TAG = "TerminalState";
	
	public string GpsLocation { get; set; }
	
	public string KeysState { get; set; }
	
	public string TamperState { get; set; }
	
	public string AndroidBuildType { get; set; }
	
	public string BootSecurity { get; set; }
	   
    }
}
