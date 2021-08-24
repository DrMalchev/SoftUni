using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Most_Freq_Nums
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int n = nums.Length;
			int[] a1 = new int[n];
			int[] a2 = new int[n];
			int length = 0;
			for (int i = n - 1; i >= 0; i--)
			{
				a1 = nums.Where(item => item == nums[i]).ToArray(); //item in array
				if (a1.Length >= length)
				{
					a2 = a1;
					length = a1.Length;
				}
			}

			
		Console.WriteLine(string.Join(" ", a2[0]));

		}
	}
}
