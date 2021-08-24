using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Convert_Speed
{
	class Program
	{
		static void Main(string[] args)
		{
			int dist = int.Parse(Console.ReadLine());
			int hours = int.Parse(Console.ReadLine());
			int min = int.Parse(Console.ReadLine());
			int sec = int.Parse(Console.ReadLine());

			int timeSec = sec + min * 60 + hours * 3600;

			Console.WriteLine($"{1.0*dist/timeSec:0.######}");
			Console.WriteLine($"{1.0*(dist/1000.0)/(timeSec/3600.0):0.######}");
			Console.WriteLine($"{1.0 * (dist / 1609.0) / (timeSec / 3600.0):0.######}");



		}
	}
}
