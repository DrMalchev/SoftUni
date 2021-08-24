using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Equal_Sums
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] input = Console.ReadLine()
							.Split(' ')
							//.Select(x => "" + x)
							.Select(x => int.Parse(x))
							.ToArray();

			int[] data = new int[input.Length + 2];

			Array.Copy(input, 0, data, 1, input.Length);

			int n = data.Length;
			int result = -1;
			for (int i = 0; i < n; i++)
			{
				int sumLeft = 0;
				for (int j = 0; j < i; j++)
				{
					sumLeft = sumLeft + data[j];
				}
				int sumRight = 0;
				for (int jj = i+1; jj < n; jj++)
				{
					sumRight = sumRight + data[jj];
				}

				if (sumRight==sumLeft)
				{
					result=i;
				}
				
			}

			if (result!=-1)
			{
				Console.WriteLine(result-1);
			}
			else
			{
				Console.WriteLine("no");
			}

		}
	}
}
