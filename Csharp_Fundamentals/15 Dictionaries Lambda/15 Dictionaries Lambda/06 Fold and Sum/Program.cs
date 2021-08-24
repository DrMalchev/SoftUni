using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Fold_and_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			int k = nums.Count / 4;

			List<int> left = nums.Take(k).Reverse().ToList();
			nums.Reverse();
			List<int> right = nums.Take(k).ToList();
			List<int> upper = left.Concat(right).ToList();
			nums.Reverse();
			List<int> lower = nums.Skip(k).Take(2*k).ToList();

			List<int> result = upper.Select( (x,y) => x + lower[y]).ToList();


			Console.WriteLine(string.Join(" ", result));






		}
	}
}
