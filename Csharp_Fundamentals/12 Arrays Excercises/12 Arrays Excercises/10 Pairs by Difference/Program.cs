using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Pairs_by_Difference
{
	class Program
	{
		static void Main(string[] args)
		{
			long[] input = Console.ReadLine()
				.Split(' ')
				//.Select(x => "" + x)
				.Select(x => long.Parse(x))
				.ToArray();

			int k = int.Parse(Console.ReadLine());

			int counter = 0;
			for (int i = 0; i < input.Length; i++)
			{
				for (int j = 0; j < input.Length; j++)
				{
					
					if ((input[i]-input[j]==k || input[i] - input[j] == -k) && i!=j)
					{
						counter++;
					}
				}
			}

			Console.WriteLine(counter/2);
		}
	}
}
