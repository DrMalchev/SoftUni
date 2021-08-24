using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Weather
{
	class Program
	{
		static void Main(string[] args)
		{

			string input = Console.ReadLine();
			Dictionary<string, List<string>> weather = new Dictionary<string, List<string>>();
			string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)(?=\|)";
			List<string> splList = new List<string>();

			while (input != "end")
			{

				if (Regex.IsMatch(input, pattern))
				{
					var splited = Regex.Matches(input, pattern);
					
					foreach (Match item in splited)
					{
						string city = item.Groups[1].Value;
						string temp = item.Groups[2].Value;
						string cond = item.Groups[3].Value;

						if (weather.ContainsKey(city)==false)
						{
							weather.Add(city,new List<string>());
							weather[city].Add(temp);
							weather[city].Add(cond);

						}
						else
						{
							weather[city] = new List<string>();
							weather[city].Add(temp);
							weather[city].Add(cond);
						}
					}

				}
				
			input = Console.ReadLine();

			}
			foreach (var pair in weather.OrderBy(x=>x.Value[0]))
			{
				Console.Write(pair.Key + " => " + pair.Value[0] + " => " +pair.Value[1]);
				Console.WriteLine();
			}

		}
	}
}
