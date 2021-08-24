using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Circle_Area
{
	class Program
	{
		static void Main(string[] args)
		{
			double radius = double.Parse(Console.ReadLine());

			Console.WriteLine($"{Math.PI*Math.Pow(radius,2):F12}");



		}
	}
}
