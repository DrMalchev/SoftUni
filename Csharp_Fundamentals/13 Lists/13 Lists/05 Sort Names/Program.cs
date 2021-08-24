﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sort_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{

			List<double> nums = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.ToList();

			nums.Sort();
			//Console.WriteLine(string.Join(" ",nums));

			foreach (var item in nums)
			{
				Console.Write(item + " <= ");
			}

		}
	}
}
