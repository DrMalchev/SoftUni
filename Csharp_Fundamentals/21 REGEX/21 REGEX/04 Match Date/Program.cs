using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Match_Date
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			//string input = @"13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016";
			string pattern = @"\b([0-3][0-9])([.\-\/])([A-Z][a-z]{2})\2([0-9]{4})\b";
			//string pattern = ".";
			var result = Regex.Matches(input, pattern);
			
			//Console.WriteLine(Regex.IsMatch(input,pattern));
			foreach (Match item in result)
			{
				Console.WriteLine("Day: " + item.Groups[1].Value
									+", Month: " + item.Groups[3].Value
									+ ", Year: " + item.Groups[4].Value
				);
			}
			

		}
	}
}
