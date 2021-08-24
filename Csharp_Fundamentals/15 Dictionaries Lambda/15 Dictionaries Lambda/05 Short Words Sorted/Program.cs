using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Short_Words_Sorted
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> words = Console.ReadLine()
				.ToLower()
				.Split(".,:;()[]\"'\\/!? ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			List<string> result = words.Where(x => x.Length < 5).ToList();
			result.Sort();
			Console.WriteLine(string.Join(", ", result.Distinct()));
		}
	}
}
