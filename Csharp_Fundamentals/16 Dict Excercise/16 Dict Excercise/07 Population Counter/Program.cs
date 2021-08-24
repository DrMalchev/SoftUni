using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Population_Counter
{
	class Program
	{
		static void Main(string[] args)
		{

			string input = Console.ReadLine();
			Dictionary<string, Dictionary<string, long>> couCity= 
			new Dictionary<string, Dictionary<string, long>>();
			//List<int> total = new List<int>(0);
			while (input != "report")
			{

				List<string> inputList = input.Split('|').ToList();
				string country = inputList[1];
				string city = inputList[0];
				long population = long.Parse(inputList[2]);
				

				if (couCity.ContainsKey(country) == false)
				{

					Dictionary<string, long> cityPop = new Dictionary<string, long>();
					cityPop.Add(city, population);
					couCity.Add(country,cityPop);
					//total.Add(population);
				}
				else
				{
					couCity[country].Add(city,population);
					//total.Add(population);
				}

				input = Console.ReadLine();
			}

			foreach (var pair in couCity.OrderByDescending(x => x.Value.Values.Sum()))
			{
				Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
				foreach (var pair2 in pair.Value.OrderByDescending(x => x.Value))
				{
					Console.WriteLine($"=>{pair2.Key}: {pair2.Value}");
				}
			}

		}
	}
}
