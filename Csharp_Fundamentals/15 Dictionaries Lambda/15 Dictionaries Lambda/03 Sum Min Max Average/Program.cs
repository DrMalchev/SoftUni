using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sum_Min_Max_Average
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] nums = new int[n];

			for (int i = 0; i < n; i++)
			{
				nums[i] = int.Parse(Console.ReadLine());
			}

			int sum = nums.Sum();
			int min = nums.Min();
			int max = nums.Max();
			double ave = nums.Average();

			Console.WriteLine("Sum = " + sum);
			Console.WriteLine("Min = " + min);
			Console.WriteLine("Max = " + max);
			Console.WriteLine("Average = " + ave);


		}
	}
}
