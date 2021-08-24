using System;
using System.Text.RegularExpressions;

public class Example
{
	public static void Main()
	{
		string pattern = @"\b([0-3][0-9])([.\-\/])([A-Z][a-z]{2})(\2)([0-9]{4})\b";
		string input = @"13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016";

		foreach (Match m in Regex.Matches(input, pattern))
		{
			Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
		}
	}
}