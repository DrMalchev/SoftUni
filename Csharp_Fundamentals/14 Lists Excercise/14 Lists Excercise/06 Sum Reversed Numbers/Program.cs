using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_Reversed_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{

			List<int> nums = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			int sum = 0;
			for (int i = 0; i < nums.Count; i++)
			{
				var sumLocal = nums[i]
					.ToString()
					.Select(c => "" + c)
					.Select(int.Parse)
					.ToList();
				sumLocal.Reverse();

				int sum2 = int.Parse(string.Join("", sumLocal));

				sum = sum + sum2;
					
			}
			Console.WriteLine(sum);



		}
	}
}
