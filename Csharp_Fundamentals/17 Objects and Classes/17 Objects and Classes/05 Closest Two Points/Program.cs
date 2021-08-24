using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Closest_Two_Points
{
	class Program
	{
		class Point
		{
			public int X { get; set; }
			public int Y { get; set; }

		}

		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			double[] xCoords = new double[n];
			double[] yCoords = new double[n];
			
			
			for (int i = 0; i < n; i++)
			{	
				string[] input = Console.ReadLine().Split(' ').ToArray();
				
				var point1 = new Point
					{
					X = double.Parse(input[0])
					};

			}


			
			



			double min = double.MaxValue;
			string[] closest = new string[2];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i!=j)
					{

					
					double dist = Math.Sqrt(Math.Pow(xCoords[i] - xCoords[j], 2) + Math.Pow(yCoords[i] - yCoords[j], 2));
						if (Math.Abs(dist) < min)
						{
						min = Math.Abs(dist);
						closest[0] = "(" + xCoords[i].ToString() + ", " + yCoords[i] + ")";
						closest[1] = "(" + xCoords[j].ToString() + ", " + yCoords[j] + ")";

						}
					}
				}
				
			}

			Console.WriteLine($"{min:F3}");
			Console.WriteLine(closest[0]);
			Console.WriteLine(closest[1]);
		}
	}
}
