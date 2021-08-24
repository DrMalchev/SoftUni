using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Remove_Negative
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine()
				.Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(s => int.Parse(s))
				.ToList();

			for (int i = 0; i < nums.Count; i++)
			{
				if (nums[i]<0)
				{
					nums.Remove(nums[i]);
					i--;
				}
			}

			nums.Reverse();

			if (nums.Count==0)
			{
				Console.WriteLine("empty");
				return;
			}

			Console.WriteLine(string.Join(" ", nums));


		}
	}
}
