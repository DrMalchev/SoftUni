using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Int_to_Hex_and_Binary
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			
			string hex = n.ToString("x");
			string binary = Convert.ToString(n,2);

			Console.WriteLine(hex.ToUpper());
			Console.WriteLine(binary);
		}
	}
}
