using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09_Reafctor_Special_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int sumStart = 0;
			int sumRunning = 0;
			bool check = false;

			for (int i = 1; i <= num; i++)
{
				sumRunning = i;
				while (i > 0)
{
					sumStart += i % 10;
					i = i / 10;
				}
				check = (sumStart == 5) || (sumStart == 7) || (sumStart == 11);
				Console.WriteLine($"{ sumRunning} -> { check}");
				sumStart = 0;
				i = sumRunning;
			}
		}
	}
}
