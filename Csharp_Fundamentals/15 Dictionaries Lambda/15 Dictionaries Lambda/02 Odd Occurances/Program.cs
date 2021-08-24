using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Occurances
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] wordsArr = Console.ReadLine()
				.ToLower()
				.Split(' ')
				//.Select(double.Parse)
				.ToArray();

			var wordsDict = new Dictionary<string, int>();
			

			foreach (var item in wordsArr)
			{
				if (wordsDict.ContainsKey(item)==false)
				{
					wordsDict.Add(item,1);
				}
				else
				{
				wordsDict[item]++;

				}
			}
			List<string> plot = new List<string>();
			foreach (var pair in wordsDict)
			{
				if (pair.Value % 2 !=0)
				{
					plot.Add(pair.Key);
				}
			}
				Console.Write(string.Join(", ", plot));

		}
	}
}
