using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hornet_Wings
{
	class Program
	{
		static void Main(string[] args)
		{
			int Nflaps = int.Parse(Console.ReadLine());
			double Mdistfor1000fl = double.Parse(Console.ReadLine());
			int P = int.Parse(Console.ReadLine());

			double distance = (Nflaps / 1000.0) * Mdistfor1000fl;
			int time = (Nflaps / P) * 5 + Nflaps/100;

			Console.WriteLine($"{distance:F2} m.");
			Console.WriteLine($"{time} s.");
		}
	}
}
