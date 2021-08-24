using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sum_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			string nums1Str = Console
				.ReadLine();
			string nums2Str = Console
				.ReadLine();

			long[] nums1 = nums1Str.Split(' ')
							.Select(long.Parse)
							.ToArray();
			long[] nums2 = nums2Str.Split(' ')
							.Select(long.Parse)
							.ToArray();

	
			if (nums1.Length > nums2.Length)
			{
				long[] newNums2 = new long[nums1.Length];
				int n = (int)(Math.Ceiling(1.0 * nums1.Length / nums2.Length));
				for (int i = 0; i < n-1; i++)
				{
					nums2Str = nums2Str +" "+ nums2Str;
				}
				nums2 = nums2Str.Split(' ')
							.Select(long.Parse)
							.ToArray();
				
				for (int i = 0; i < nums1.Length; i++)
				{
					newNums2[i] = nums2[i];
				}
				nums2Str = string.Join(" ", newNums2);

				//Console.WriteLine(string.Join(" ", nums1Str));
				//Console.WriteLine(string.Join(" ", nums2Str));


				AddAndPrintTwoStrings(nums1Str, nums2Str);
			}

			else if (nums1.Length < nums2.Length)
			{

				long[] newNums1 = new long[nums2.Length];
				int n = (int)(Math.Ceiling(1.0 * nums2.Length / nums1.Length));
				for (int i = 0; i < n - 1; i++)
				{
					nums1Str = nums1Str + " " + nums1Str;
				}
				nums1 = nums1Str.Split(' ')
							.Select(long.Parse)
							.ToArray();

				for (int i = 0; i < nums2.Length; i++)
				{
					newNums1[i] = nums1[i];
				}
				nums1Str = string.Join(" ", newNums1);

				//Console.WriteLine(string.Join(" ", nums1Str));
				//Console.WriteLine(string.Join(" ", nums2Str));


				AddAndPrintTwoStrings(nums1Str, nums2Str);


			}
			else
			{
				AddAndPrintTwoStrings(nums1Str, nums2Str);
			}
		}

		static void AddAndPrintTwoStrings(string nums1Str, string nums2Str)
		{
			long[] nums1 = nums1Str.Split(' ')
							.Select(long.Parse)
							.ToArray();
			long[] nums2 = nums2Str.Split(' ')
			.Select(long.Parse)
			.ToArray();

			long[] result = new long[nums1.Length];
			result = nums1.Select((x, index) => x + nums2[index]).ToArray();

			Console.WriteLine(string.Join(" ", result));
		}
		
		
		
		
	}
}
