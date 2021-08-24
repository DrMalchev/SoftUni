using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Largest_Num
{
	class Program
	{
		static void Main(string[] args)
		{

			List<double> nums = Console.ReadLine()
				.Split(' ')
				.Select(double.Parse)
				.ToList();

			if (nums.Count>3)
			{
				Console.WriteLine(string.Join(" ", nums.OrderByDescending(x => x).Take(3)));
			}
			else
			{
				Console.WriteLine(string.Join(" ", nums.OrderByDescending(x => x)));
			}
		}
	}
}
