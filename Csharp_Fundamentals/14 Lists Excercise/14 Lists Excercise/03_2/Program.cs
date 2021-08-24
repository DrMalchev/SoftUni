using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine()
				.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			List<int> three = Console.ReadLine()
				.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			if (nums.Take(three[0]).Skip(three[1]).Contains(three[2]))
			{
				Console.WriteLine("YES!");
			}
			else
			{
				Console.WriteLine("NO!");
			}
		}
	}
}
