using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Comparing_Floats
{
	class Program
	{
		static void Main(string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());

			double diff = Math.Abs(a - b);
			if (diff<=1e-6)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}

		}
	}
}
