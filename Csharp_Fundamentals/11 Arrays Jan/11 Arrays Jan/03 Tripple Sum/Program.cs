using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tripple_Sum
{
	class Program
	{
		static void Main(string[] args)
		{

			var nums = Console
				.ReadLine().Split(' ')
				.Select(s => long.Parse(s))
				.ToArray();
	
			bool no = false;
			for (long i = 0; i < nums.Length-1; i++)
			{
				for (long j = 1; j < nums.Length; j++)
				{
					for (long k = 0; k < nums.Length; k++)
					{
						if ((nums[i] + nums[j] == nums[k]) 
							&& i<j 
							//&& k!=i
							//&&k!=j
							//&& nums[i] >= 0
							//&& nums[j] >= 0
							)
						{
							Console.WriteLine(nums[i] + " + " + nums[j] + " == "+nums[k]);
							no = true;
							break;
						}
						
					}
				}
			}
			if (no==false)
			{
				Console.WriteLine("No");
			}

		}
	}
}
