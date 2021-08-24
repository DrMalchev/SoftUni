using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Exchange_Var_Values
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine("Before:");
			Console.WriteLine($"a = {b}");
			Console.WriteLine($"b = {a}");
			Console.WriteLine("After:");
			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");
		}
	}
}
