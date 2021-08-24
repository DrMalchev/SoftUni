using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Convert_to_Nanoseconds
{
	class Program
	{
		static void Main(string[] args)
		{
			int cent = int.Parse(Console.ReadLine());

			int years = cent * 100;
			int days = (int)(years * 365.2422);
			int hours = days*24;
			long minutes = hours * 60;
			long min = hours * 60;
			long sec = min * 60;

			Console.WriteLine($"{cent} centuries = {years} years = {days} days = {hours} " +
				$"hours = {min} minutes = {sec} seconds = {sec}000 milliseconds = {sec}000000 microseconds = {sec}000000000 nanoseconds");

		}
	}
}
