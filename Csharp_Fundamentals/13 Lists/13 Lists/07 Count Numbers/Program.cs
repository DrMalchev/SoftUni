using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Count_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{

			List<int> nums = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			nums.Sort();

			//List<int> distinct = nums.Distinct().ToList();


			int[] counter = new int[nums.Count];
			for (int i = 0; i < nums.Count; i++)
			{
				counter[i] = 1;
				for (int j = 0; j < nums.Count; j++)
				{
					if (nums[i]==nums[j] && i!=j)
					{
						counter[i]++;
					}
				}
			}

			Console.WriteLine(nums[0] + " -> " + counter[0]);
			for (int i = 1; i < nums.Count; i++)
			{
				if (nums[i]!=nums[i-1])
				{
					Console.WriteLine(nums[i] + " -> " + counter[i]);
				}
				
			}
			




		}
	}
}
