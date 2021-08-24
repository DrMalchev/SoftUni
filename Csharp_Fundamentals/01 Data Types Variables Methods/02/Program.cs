using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			if (n<16)
			{
				double a = double.Parse(Console.ReadLine());
				Console.WriteLine(a);
			}
			else
			{
				decimal a = decimal.Parse(Console.ReadLine());
				Console.WriteLine(a);
			}
		}
	}
}
