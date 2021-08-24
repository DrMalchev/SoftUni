using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Search_for_a_Number
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

			nums.Take((int)three[0]);
			if (three[1]>nums.Count)
			{
				Console.WriteLine("NO!");
				return;
			}
			else if (three[0]==0)
			{
				Console.WriteLine("NO!");
				return;
			}
			nums.RemoveRange(0, (int)three[1]);

			int[] search = nums.Where(item => item == three[2]).ToArray(); //item in array

			if (search.Length>=1)
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
