﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03_Factoriel
{
	class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());
			BigInteger sum = 1;

			for (int i = 1; i < n; i++)
			{
				sum = sum+sum * i;
			}

			Console.WriteLine(sum);



		}
	}
}
