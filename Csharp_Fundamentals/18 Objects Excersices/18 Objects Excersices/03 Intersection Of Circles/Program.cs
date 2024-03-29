﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Intersection_Of_Circles
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

			Circle circle1 = new Circle();
			circle1.Center = new Point();
			circle1.Center.X = input[0];
			circle1.Center.Y = input[1];
			circle1.Radius = input[2];

			double[] input2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

			Circle circle2 = new Circle();
			circle2.Center = new Point();
			circle2.Center.X = input2[0];
			circle2.Center.Y = input2[1];
			circle2.Radius = input2[2];

			if (circle1.IsÍnresected(circle2))
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}

		}
	}

	class Point
	{
		public double X{ get; set; }
		public double Y { get; set; }

	}

	class Circle
	{
		public Point Center{ get; set; }
		public double Radius{ get; set; }

		public bool IsÍnresected(Circle circle)
		{
			double distance = Math.Sqrt(Math.Pow(circle.Center.X-Center.X,2) + Math.Pow(circle.Center.Y - Center.Y, 2));
			if (distance<= circle.Radius+Radius)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
