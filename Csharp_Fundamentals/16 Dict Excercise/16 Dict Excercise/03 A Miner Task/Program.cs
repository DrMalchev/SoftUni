using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_A_Miner_Task
{
	class Program
	{
		static void Main(string[] args)
		{
			string start = Console.ReadLine();
			List<string> input = new List<string>();
			input.Add(start);

			while (start != "stop")
			{

				start = Console.ReadLine();
				input.Add(start);
				

			}
			input.RemoveAt(input.Count-1);

			string[] even = input.Where((x, i) => i % 2 == 0).ToArray(); //index of array
			int[] odd = input.Where((x, i) => i % 2 != 0).Select(int.Parse).ToArray(); //index of array

			Dictionary<string, int> resDict = new Dictionary<string, int>();

			for (int i = 0; i < even.Length; i++)
			{
				if (resDict.ContainsKey(even[i]) == false)
				{
					resDict.Add(even[i], odd[i]);
				}
				else
				{
					resDict[even[i]] += odd[i];
					
				}

			}

			foreach (var pair in resDict)
			{
				Console.WriteLine($"{pair.Key} -> {pair.Value}");
			}

		}
	}
}
