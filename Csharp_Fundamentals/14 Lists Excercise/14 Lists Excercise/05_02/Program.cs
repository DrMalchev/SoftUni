using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Array_Manipulator
{
	public class Program
	{
		public static void Main()
		{
			var nums = Console.ReadLine()
				.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse).ToList();

			var com = Console.ReadLine()
				.ToLower()
				.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

			while (com[0] != "print")
			{
				switch (com[0])
				{
					case "add":
						int index1 = int.Parse(com[1]);
						int element1 = int.Parse(com[2]);
						nums.Insert(index1, element1);
						break;

					case "addmany":
						int index2 = int.Parse(com[1]);
						int[] elements2 = new int[com.Length - 2];
						for (int i = 2; i < com.Length; i++)
						{
							elements2[i - 2] = int.Parse(com[i]);
						}
						nums.InsertRange(index2, elements2);
						break;

					case "contains":

						int element3 = int.Parse(com[1]);
						bool contains = nums.Contains(element3);
						if (contains)
						{
							Console.WriteLine(nums.FindIndex(x => x == element3));
						}
						else
						{
							Console.WriteLine("-1");
						}

						break;

					case "remove":
						var index4 = int.Parse(com[1]);
						if (index4 > nums.Count - 1 || index4 < 0)
						{
							Console.WriteLine("[" + string.Join(", ", nums) + "]");
							return;
						}
						nums.RemoveAt(index4);
						break;

					case "shift":
						var position = int.Parse(com[1]);
						if (position > nums.Count)
						{
							position = position % nums.Count;
						}
						int left = position;
						var listLeft = nums.Take(left).ToList();
						var listRight = nums;
						listRight.RemoveRange(0, left);
						listRight.AddRange(listLeft);
						nums = listRight;
						break;

					case "sumpairs":
						var even = nums.Where((x, i) => i % 2 == 0).ToList();
						var odd = nums.Where((x, i) => i % 2 != 0).ToList();
						if (even.Count > odd.Count)
						{
							odd.Add(0);
						}
						else
						{
							even.Add(0);
						}
						nums.Clear();
						nums = even.Zip(odd, (x, y) => x + y).ToList();
						break;
						//default:
						//  Console.WriteLine("Incorrect input");
						//  return;
				}
				string[] comW = Console.ReadLine()
								.ToLower()
								.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				com = comW;
			}
			Console.WriteLine("[" + string.Join(", ", nums) + "]");
		}
	}
}