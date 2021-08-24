using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Match_Hexadecimal
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> plot = new List<string>();
			//string pattern = @"\b(0x|)([0-9]+|[A-F]+|[0-9][A-F]|[A-F]+[0-9]+)\b";
			string pattern = @"\b(?:0x)?[0-9A-F]+\b";
			var result = Regex.Matches(Console.ReadLine(), pattern);
			foreach (Match item in result)
			{
				plot.Add(item.Value);
			}

			Console.WriteLine(string.Join(" ", plot));

		}
	}
}
