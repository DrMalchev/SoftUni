using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sum_Adjacent_Equal_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{

			List<double> nums = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => double.Parse(x))
				.ToList();

			for (int i = 1; i < nums.Count; i++)
			{
				if (nums[i-1]==nums[i])
				{
					nums[i - 1] = nums[i - 1] + nums[i];
					nums.RemoveAt(i);
					i=0;
				}
			}

			Console.WriteLine(string.Join(" ",nums));

		}
	}
}
