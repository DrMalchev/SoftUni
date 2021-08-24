using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_and_Sum
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

			int rows = int.Parse(Console.ReadLine());

			int[,] rotated = new int[rows, nums.Length];

			for (int i = 0; i < rows; i++)
			{
				
					rotated[i, 0] = nums[nums.Length-1];
					for (int l = 1; l < nums.Length; l++)
					{
						rotated[i, l] = nums[l-1];
					}
				
				nums = GetRow(rotated, i);
				//Console.WriteLine(string.Join(" ", nums));
			}

			// print & sum
			int[] sum = new int[rotated.GetLength(1)];

			for (int i = 0; i < nums.Length; i++)
			{
				int[] sumCol = GetColumn(rotated,i);
				Console.Write(sumCol.Sum()+" ");
			}

		}

		static int[] GetRow(int[,] rotated, int i) //matrix rotated [,] and Row i
		{
			int n = rotated.GetLength(1);
			int[] result = new int[n]; //numb of columns

			for (int iMethod = 0; iMethod < n; iMethod++)
			{
				result[iMethod] = rotated[i,iMethod];
			}

			return result;
		}


		static int[] GetColumn(int[,] rotated, int i)
		{
			int n = rotated.GetLength(0);
			int[] result = new int[n]; //numb of columns

			for (int iMethod = 0; iMethod < n; iMethod++)
			{
				result[iMethod] = rotated[iMethod,i];
			}

			return result;
		}
	}
}
