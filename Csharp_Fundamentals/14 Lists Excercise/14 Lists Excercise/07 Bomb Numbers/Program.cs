using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Bomb_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{

			List<int> nums = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			List<int> bomb = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();


			while (nums.Contains(bomb[0]))
			{
				int start = nums.FindIndex(x => x == bomb[0]) - bomb[1];
				int end = nums.FindIndex(x => x == bomb[0]) + bomb[1];

				if (start<0)
				{
					start = 0;
				}
				else if (start>nums.Count-1)
				{
					start = nums.Count-1;
				}
				else if (end<0)
				{
					end = 0;
				}
				else if (end > nums.Count-1)
				{
					end = nums.Count-1;
				}
				

				nums.RemoveRange(start,end-start+1);
			}

			Console.WriteLine(nums.Sum());




		}
	}
}
