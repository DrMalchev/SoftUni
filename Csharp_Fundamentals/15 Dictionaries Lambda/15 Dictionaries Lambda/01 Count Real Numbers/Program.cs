using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Count_Real_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] numsArr = Console.ReadLine()
				.Split(' ')
				.Select(double.Parse)
				.ToArray();

			var countDict = new SortedDictionary<double, int>();

			foreach (double item in numsArr)
			{
				if (countDict.ContainsKey(item))
				{
					countDict[item]++;
				}
				else
				{
					countDict.Add(item,1);
				}
			}

			foreach (var item in countDict)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}


		}
	}
}
