using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01_Padawn_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			int countStudents = int.Parse(Console.ReadLine());
			double price1Sabre = double.Parse(Console.ReadLine());
			double price1Robe = double.Parse(Console.ReadLine());
			double price1Belt = double.Parse(Console.ReadLine());

			double money = 0;
		
			money = price1Sabre * (Math.Ceiling(countStudents * 1.1)) + price1Robe * countStudents + price1Belt * (countStudents - countStudents/6);

			if (money<=budget)
			{
				Console.WriteLine($"The money is enough - it would cost {(money):F2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivan Cho will need {(money-budget):F2}lv more.");
			}
		}
	}
}
