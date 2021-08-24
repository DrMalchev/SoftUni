using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_Valid_User_Names
{
	class Program
	{
		static void Main(string[] args)
		{

			string input = Console.ReadLine();//@"chico/ gosho \ sapunerka (3sas) mazut  lelQ_Van4e";

			List<string> inpList = input.Split("\\)(/ ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToList();

			//ceck validity of user names
			input = string.Join(" ",inpList);
			string pattern = @"\b[a-zA-z][a-zA-Z0-9_]{2,24}\b";
			var result = Regex.Matches(input, pattern);
			inpList.Clear();
			foreach (Match item in result)
			{
				inpList.Add(item.Value);
			}

			List<int> lengths = new List<int>();
			foreach (var item in inpList)
			{
				lengths.Add(item.Length);
			}

			List<int> groupLengths = new List<int>();
			for (int i = 0; i < lengths.Count-1; i++)
			{
				groupLengths.Add(lengths[i]+lengths[i+1]);
			}

			int max = groupLengths.Max();

			for (int i = 0; i < groupLengths.Count; i++)
			{
				if (groupLengths[i]==max)
				{
					Console.WriteLine(inpList[i]);
					Console.WriteLine(inpList[i+1]);
					return;

				}
			}
			
		}
	}
}
