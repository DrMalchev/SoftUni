using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Boolean_Var
{
	class Program
	{
		static void Main(string[] args)
		{
			string n = Console.ReadLine().ToLower();

			if (Convert.ToBoolean(n))
			{
Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
			
		}
	}
}
