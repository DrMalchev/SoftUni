using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Water_Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int capacity = 255;
			
			int liters = 0;
			
			for (int i = 0; i < n; i++)
			{
				int inp=int.Parse(Console.ReadLine());
				liters = liters + inp; 

				if (liters>capacity)
				{
					Console.WriteLine("Insufficient capacity!");
					liters = liters - inp;
				}
			}
			Console.WriteLine(liters);


		}
	}
}
