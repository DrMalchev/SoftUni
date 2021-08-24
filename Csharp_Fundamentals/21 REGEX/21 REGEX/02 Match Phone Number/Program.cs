using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Match_Phone_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> plot = new List<string>();	
		var result = Regex.Matches(Console.ReadLine(), @"(\+359)([ |-])(2)\2[0-9]{3}\2[0-9]{4}\b");
			foreach (Match item in result)
			{
				plot.Add(item.Value);
			}

			Console.WriteLine(string.Join(", ",plot));

		}
	}
}
