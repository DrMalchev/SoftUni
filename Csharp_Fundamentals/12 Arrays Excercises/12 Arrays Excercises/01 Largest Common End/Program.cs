using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Common_End
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr1 = Console.ReadLine().Split(' ').ToArray();
			string[] arr2 = Console.ReadLine().Split(' ').ToArray();

			//Left to right

			int counterLR = 0;
			for (int i = 0; i < Math.Min(arr1.Length,arr2.Length); i++)
			{
				if (arr1[i]==arr2[i])
				{
					counterLR++;
				}
			}

			//Right to Left
			int counterRL = 0;
			if (arr1.Length<arr2.Length)
			{
				string[] temp = new string[arr2.Length];
				temp = temp.Select(i => "0").ToArray();
				int startIndex = arr2.Length-arr1.Length;
				int endIndex = arr2.Length;
				Array.Copy(arr1, 0, temp, startIndex, endIndex-startIndex);
				arr1 = temp;

				//Console.WriteLine(string.Join(" ", arr1));
			}
			else
			{
				string[] temp = new string[arr1.Length];
				temp = temp.Select(i => "0").ToArray();
				int startIndex = arr1.Length - arr2.Length;
				int endIndex = arr1.Length;
				Array.Copy(arr2, 0, temp, startIndex, endIndex - startIndex);
				arr2 = temp;

				//Console.WriteLine(string.Join(" ", arr2));
			}

			for (int i = arr1.Length - 1; i >= 0; i--)
			{
				if (arr1[i]==arr2[i])
				{
					counterRL++;
				}
			}

			if (counterLR>counterRL)
			{
				Console.WriteLine(counterLR);
			}
			else
			{
				Console.WriteLine(counterRL);
			}

		}
	}
}
