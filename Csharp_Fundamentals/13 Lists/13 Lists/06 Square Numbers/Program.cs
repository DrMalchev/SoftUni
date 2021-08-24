using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Square_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> nums = Console.ReadLine()
				.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
				.Select(x => double.Parse(x))
				.ToList();

			List<double> result = new List<double>();
			foreach (var item in nums)
			{
				if (Math.Sqrt(item)%1==0  )
				{
					result.Add(item);
				}
			}
			result.Sort();
			result.Reverse();

			Console.WriteLine(string.Join(" ",result));

		}
	}
}
