using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = new List<int>() {1, 2, 3, 4};

			int n = nums.Count;
			int[] numsA = new int[n];
			if (nums.Count % 2 == 0)
			{
				List<int> sum1 = new List<int>();
				List<int> sum2 = new List<int>();

				for (int i = 0; i < n / 2; i++)
				{
					if (i % 2 == 0)
					{
						sum1.Add(nums[i]);
					}
					else
					{
						sum2.Add(nums[i]);
					}
				}
				nums.Clear();
				
				for (int i = 0; i < n / 2; i++)
				{
					numsA[i] = sum1[i] + sum2[i];
				}
				//List<int> even = nums.Where((x, i) => i % 2 == 0).ToList();
				//List<int> odd = nums.Where((x, i) => i % 2 != 0).ToList();

				//if (even.Count>odd.Count)
				//{
				//	odd.Add(0);
				//}
				//else
				//{
				//	even.Add(0);
				//}
				//nums.Clear();
				//nums = even.Zip(odd, (x, y) => x + y).ToList();

			}
			Console.WriteLine(string.Join(" ", numsA));


		}


	}
}
