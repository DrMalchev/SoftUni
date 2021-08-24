using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Anonymos_Cache
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
			Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
			string dataset = "";
			string datakey = "";
			long datasize = 0;

			while (input!= "thetinggoesskrra")
			{
				string[] info = input.Split(" ->|".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();

				if (info.Length==1)
				{
					dataset = info[0];
					if (data.ContainsKey(dataset)==false)
					{
						Dictionary<string, long> current = new Dictionary<string, long>();
						if (cache.ContainsKey(dataset))
						{
							current = cache[dataset];
						}
						data.Add(dataset,current);
					}
				}
				else
				{
					dataset = info[2];
					datasize = long.Parse(info[1]);
					datakey = info[0];

					if (data.ContainsKey(dataset)==false)
					{
						Dictionary<string, long> current = new Dictionary<string, long>();
						current.Add(datakey,datasize);
						if (cache.ContainsKey(dataset)==false)
						{
						cache.Add(dataset, current);
						}
						else
						{
							//todo or do nothing, only his majesty judge will tell
							cache[dataset].Add(datakey, datasize);
						}
					}
					else
					{
						data[dataset].Add(datakey, datasize);
					}

				}

				input = Console.ReadLine();
			}

			string print = "";
			foreach (var pair in data.OrderByDescending(x=>x.Value.Values.Sum()))
			{
				Console.WriteLine($"Data Set: {pair.Key}, Total Size: {pair.Value.Values.Sum()}");
				foreach (var pair2 in pair.Value)
				{
					Console.WriteLine($"$.{pair2.Key}");

				}
				break;
			}

		}
	}
}
