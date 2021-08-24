using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Last_K_Num_Sums
{
	class Program
	{
		static void Main(string[] args)
		{
			long n = long.Parse(Console.ReadLine());
			long k = long.Parse(Console.ReadLine());
			long[] nums  = new long[n+k];
			Array.Clear(nums, 0, nums.Length);
			nums[k] = 1;
			Console.Write(nums[k]+" ");

			for (long i = k+1; i < n+k; i++)
			{
				for (long j = 1; j <= k; j++)
				{
					nums[i] = nums[i]+nums[i - j];
				}
				Console.Write(nums[i]+" ");
			}

		}
	}
}
