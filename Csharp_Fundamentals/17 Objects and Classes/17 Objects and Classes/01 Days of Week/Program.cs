﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Days_of_Week
{
	class Program
	{
		static void Main(string[] args)
		{

			var day = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy",null);

			Console.WriteLine(day.DayOfWeek);

		}
	}
}
