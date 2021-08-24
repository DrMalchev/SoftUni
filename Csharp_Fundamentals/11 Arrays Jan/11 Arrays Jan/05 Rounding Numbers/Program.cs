using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rounding_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] numsStr = Console
						.ReadLine().Split(' ');
						

			double[] nums = numsStr
						.Select(s => double.Parse(s))
						.ToArray();

			double round;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i]-0.5==Math.Floor(nums[i]))
				{
					// case 0.5
					round = Math.Sign(nums[i])*(Math.Abs(nums[i])+0.5);
					Console.WriteLine($"{numsStr[i]} => {round:F0}");
				}
				else
				{
					//case != 0.5
					round = Math.Round(nums[i]);
					Console.WriteLine($"{numsStr[i]} => {round:F0}");
				}
			}

		}
	}
}
