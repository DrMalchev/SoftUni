using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Elevator
{
	class Program
	{
		static void Main(string[] args)
		{

			double NumOfPeople = double.Parse(Console.ReadLine());
			double capacityLift = double.Parse(Console.ReadLine());
			Console.WriteLine(Math.Ceiling(NumOfPeople/capacityLift));

		}
	}
}
