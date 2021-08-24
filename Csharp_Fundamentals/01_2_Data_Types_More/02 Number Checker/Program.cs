using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Number_Checker
{
	class Program
	{
		static void Main(string[] args)
		{
			double n = double.Parse(Console.ReadLine());

			if (n==Math.Floor(n))
			{
				Console.WriteLine("integer");
			}
			else
			{
				Console.WriteLine("floating-point");
			}
		}
	}
}
