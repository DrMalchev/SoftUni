using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_Match_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{

			string pattern = @"(^|(?<=\s))((?:-)?(\d+))?(?:\.)?(\d+)?($|(?=\s))";
			string input = Console.ReadLine();//@"1 -1 1s 123 s-s -123 _55_ _f 123.456 -123.456 s-1.1 s2 -1- zs-2 s-3.5";

			var result = Regex.Matches(input, pattern);

			foreach (Match item in result)
			{
				Console.Write(item.Value+" ");
			}

		}
	}
}
