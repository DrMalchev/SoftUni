﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
	class Program
	{
		static void Main(string[] args)
		{
			byte first = byte.Parse(Console.ReadLine());
			uint second = uint.Parse(Console.ReadLine());
			int third= int.Parse(Console.ReadLine());
			long fourth = long.Parse(Console.ReadLine());


			Console.WriteLine("{0} {1} {2} {3}",first,second,third,fourth);
		}
	}
}
