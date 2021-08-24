using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Distance_between_Points
{
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

	}

	class Program
	{
		static void Main(string[] args)
		{

			var firstPoint = Console.ReadLine().Split(' ');

			var point1 = new Point
			{
				X = int.Parse(firstPoint[0]),
				Y = int.Parse(firstPoint[1])
			};

			var secondPoint = Console.ReadLine().Split(' ');

			var point2 = new Point
			{
				X = int.Parse(secondPoint[0]),
				Y = int.Parse(secondPoint[1])
			};

			Console.WriteLine($"{Distance(point1, point2):F3}");

			
		}

		static double Distance(Point first, Point second)
		{
			

			return Math.Sqrt(Math.Pow(first.X-second.X,2)+Math.Pow(first.Y - second.Y,2));
		}
	}
}
