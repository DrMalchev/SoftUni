using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Resurrection
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			decimal[] totalYears = new decimal[N];

			for (int i = 0; i < N; i++)
			{
				long totalLength = long.Parse(Console.ReadLine());
				decimal totalWidth = decimal.Parse(Console.ReadLine());
				int lengthOfWing = int.Parse(Console.ReadLine());

				totalYears[i] = totalLength*totalLength*(totalWidth+2*lengthOfWing);
				

			}

			for (int i = 0; i < N; i++)
			{
				Console.WriteLine(totalYears[i]);
			}



		}
	}
}
