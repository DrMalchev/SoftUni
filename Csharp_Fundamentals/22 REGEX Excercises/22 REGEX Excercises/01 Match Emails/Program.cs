using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Match_Emails
{
	class Program
	{
		static void Main(string[] args)
		{

			string input = Console.ReadLine();
			string pattern = @"(^|(?<=\s))([0-9a-zA-Z]+)([.\-_]{0,1})(?!@)([0-9A-Za-z])*@([a-zA-Z0-9]+)([-.]{0,1}[a-zA-Z0-9])*([\.]{1})([0-9a-z]+)";
			//string input = @"Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.";

			var result = Regex.Matches(input, pattern);

			foreach (Match item in result)
			{
				Console.WriteLine(item.Value);
			}

		}
	}
}
