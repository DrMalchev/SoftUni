using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Name
{
	class Program
	{
		static void Main(string[] args)
		{
			var result = Regex.Matches(Console.ReadLine(), @"\b[A-Z]{1}[a-z]+ [A-Z][a-z]+\b");
			foreach (Match item in result)
			{
				Console.Write(item.Value + " ");
			}
		}
	}
}
