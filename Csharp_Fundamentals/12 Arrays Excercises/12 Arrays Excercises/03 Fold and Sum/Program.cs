using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Fold_and_Sum
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] nums = Console
				.ReadLine()
				.Split(' ')
				.Select(s => int.Parse(s))
				.ToArray();

			int n = nums.Length;

			int[] middle = new int[n/2];
			for (int i = n/4; i < n/2+n/4; i++)
			{
				middle[i-n/4] = nums[i];
			}

			//Console.WriteLine(string.Join(" ",middle));

			int[] front = new int[n / 4];
			for (int i = 0; i < n / 4 ; i++)
			{
				front[i] = nums[i];
			}
			front = front.Reverse().ToArray();
			//Console.WriteLine(string.Join(" ", front));

			int[] back = new int[n / 4];
			for (int i = n/2+n/4; i < n; i++)
			{
				back[i-n/2-n/4] = nums[i];
			}
			back = back.Reverse().ToArray();
			//Console.WriteLine(string.Join(" ", back));

			int[] combined = front.Concat(back).ToArray();

			//Console.WriteLine(string.Join(" ", combined));


			for (int i = 0; i < middle.Length; i++)
			{
				int sum = middle[i] + combined[i];
				Console.Write(sum+" ");
			}

		}
	}
}
