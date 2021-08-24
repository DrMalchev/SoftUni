using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Wormtest
{
	class Program
	{
		static void Main(string[] args)
		{
			int LengthM = int.Parse(Console.ReadLine());
			double WidthCm = double.Parse(Console.ReadLine());

			int LengthCm = LengthM * 100;
			if (LengthCm % WidthCm == 0 || WidthCm==0)
			{
				Console.WriteLine($"{LengthCm*WidthCm:F2}");
			}
			else if(LengthCm % WidthCm != 0 && WidthCm!=0)
			{
				Console.WriteLine($"{LengthCm *100/ WidthCm:F2}%");
			}
		}
	}
}
