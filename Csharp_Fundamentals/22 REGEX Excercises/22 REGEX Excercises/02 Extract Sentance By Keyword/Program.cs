using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Extract_Sentance_By_Keyword
{
	class Program
	{
		static void Main(string[] args)
		{
			//string word = "To";
			//string input = "Welcome to SoftUni!You will learn programming, algorithms, problem solving and software technologies.To need to, allocate for study 20 - 30 hours weekly.Good luck!I am fan of Motorhead.To be or not To be - that is the question. TO DO OR NOT ?";
			string word = Console.ReadLine();
			string input = Console.ReadLine();
			List<string> firstSplitStr = input
			.Split("?!.".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToList();

			//Console.WriteLine(string.Join("|",firstSplitStr));

			foreach (var item in firstSplitStr)
			{
				var secondSplit = item.Split(@" !\/[]#*+0123456789%&(|<>-_,.)=?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
				foreach (var item2 in secondSplit)
				{
					if (item2 == word)
					{
						Console.WriteLine(item);
					}
				}

			}



		}
	}
}
