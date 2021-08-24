using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hornet_Armada
{
	class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());
			Dictionary<string, Dictionary<string, long>> army = new Dictionary<string, Dictionary<string, long>>();
			Dictionary<string, int> actDict = new Dictionary<string, int>();

			for (int i = 0; i < n; i++)
			{

				string[] info = Console.ReadLine().Split(" =->:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
				int activity = int.Parse(info[0]);
				string name = info[1];
				string type = info[2];
				long count = long.Parse(info[3]);

				if (army.ContainsKey(name)==false)
				{
					Dictionary<string, long> current = new Dictionary<string, long>();
					current.Add(type,count);
					
					army.Add(name, current);

				}
				else
				{
					if (army[name].ContainsKey(type)==false)
					{
						army[name].Add(type, count);
					}
					else
					{
						army[name][type] += count;
					}
					
				}

				if (actDict.ContainsKey(name)==false)
				{
					actDict.Add(name, activity);
				}
				else
				{
					if (actDict[name]<activity)
					{
						actDict[name] = activity;
					}
				}
			}

			string[] commands = Console.ReadLine().Split("\\".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();

			if (commands.Length==1)
			{
				foreach (var pair in actDict.OrderByDescending(x=>x.Value))
				{
					if (army[pair.Key].ContainsKey(commands[0]))
					{
					Console.WriteLine($"{pair.Value} : {pair.Key}");
					}

				}
			}
			else
			{
				foreach (var pair in army.Where(x=>x.Value.ContainsKey(commands[1])).OrderByDescending(x=>x.Value[commands[1]]))
				{
					if (actDict[pair.Key]<int.Parse(commands[0]))
					{
						Console.WriteLine($"{pair.Key} -> {pair.Value[commands[1]]}");
					}
				}
			}

		}
	}

}
