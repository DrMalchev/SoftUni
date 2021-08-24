using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rectangle
{
	class Program
	{

		class Rectangle
		{
			public int Top { get; set; }
			public int Width { get; set; }
			public int Left { get; set; }
			public int Height { get; set; }

			public int Bottom
			{
				get
				{
					return Top + Height;
				}
			}
			public int Right
			{
				get
				{
					return Left + Width;
				}
			}


			public int CalcArea()
			{
				return Width * Height;
			}

			public bool IsInside(Rectangle other)
			{
				return Left >= other.Left &&
				Right <= other.Right &&
				Bottom <= other.Bottom &&
				Top >= other.Top;
			}


		}

		static void Main(string[] args)
		{
			var firstRectangle = ReadRectangle();
			var secondRectangle = ReadRectangle();

			var result = firstRectangle.IsInside(secondRectangle);

			Console.WriteLine(result ? "Inside" : "Not Inside");
		}

		static Rectangle ReadRectangle()
		{
			var recData = Console.ReadLine().Split(' ');
			
			return new Rectangle
			{
			Left = int.Parse(recData[0]),
			Top = int.Parse(recData[1]),
			Width = int.Parse(recData[2]),
			Height = int.Parse(recData[3])

			};
		}
	}
}
