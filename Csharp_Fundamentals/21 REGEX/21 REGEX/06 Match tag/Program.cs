using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_Match_tag
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "end")
			{

				string pattern = @"(<a)(.*?>)(.+(?=<))|(<)(\/)(a)>";
				//string input = @"<a href=""http://softuni.bg"">SoftUni</a>";

				List<string> matchGr = new List<string>();
				List<int> ind = new List<int>();

				if (Regex.IsMatch(input, pattern))
				{
					var result = Regex.Matches(input, pattern);
					int matchC = result.Count;
					
					//Console.WriteLine(matchC);

					foreach (Match item in result)
					{
						ind.Add(item.Value.IndexOf('<'));
						matchGr.Add(item.Groups[matchC - 1].Value);
						matchGr.Add(item.Groups[matchC].Value);
						matchGr.Add(item.Groups[matchC + 1].Value);

						matchC = 4;

					}
					Console.Write("[URL");
					Console.Write(matchGr[1].Remove(matchGr[1].Length - 1));
					Console.Write("]");
					Console.Write(matchGr[2]);
					Console.Write("[/URL]");

				}
				else
				{
					Console.WriteLine(input);
				}

				input = Console.ReadLine();
				Console.WriteLine(string.Join("|",ind));

			}
		}
	}
}
