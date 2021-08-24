using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condense_Array_to_Num
{
	class Program
	{
		static void Main(string[] args)
		{
			string arrStr = Console
				.ReadLine();

			long[] arr = arrStr.Split(' ')
							.Select(long.Parse)
							.ToArray();

			while (arr.Length>1)
			{
				long[] arr2 = new long[arr.Length - 1];
				for (int i = 0; i < arr.Length-1; i++)
				{
					arr2[i] = arr[i] + arr[i + 1];
				}
				arr = new long[arr2.Length];
				arr = arr2;

			}
			Console.WriteLine(arr.Sum());

		}
	}
}
