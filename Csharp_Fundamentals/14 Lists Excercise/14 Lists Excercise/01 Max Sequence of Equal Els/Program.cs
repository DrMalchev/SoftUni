using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Max_Sequence_of_Equal_Els
{
	class Program
	{
		static void Main(string[] args)
		{
			List<long> nums = Console.ReadLine()
				.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
				.Select(long.Parse)
				.ToList();

			// 1 1 0 1 2 3 2 2 2
			int counter = 1;
			int index = 0;
			int CounterMax = 1;
			int indexMax = 0;
			for (int i = nums.Count-1; i >= 1; i--)
			{
				if (nums[i]==nums[i-1])
				{
					counter++;
					index = i-1;
					
				}
				else
				{
					counter = 1;
					index = 1;
				}
				if (counter >= CounterMax)
				{
					CounterMax = counter;
					indexMax = index;
				}
			}

			if (CounterMax!=1)
			{
				for (int i = 0; i < CounterMax; i++)
				{
					Console.Write(nums[indexMax]+" ");
				}
			}
			else
			{
				Console.Write(nums[0]);
			}
			
			
			
		}
	}
}
