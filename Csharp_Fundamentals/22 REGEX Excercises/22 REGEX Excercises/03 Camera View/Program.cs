using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Camera_View
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] com = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int m = com[0];
			int n = com[1];
			string input = Console.ReadLine();
			string pattern = @"(\|<)";


			string[] splited = Regex.Split(input,pattern);
			bool mark = false;
			List<string> plot = new List<string>();
			foreach (string item in splited)
			{
				if (mark==true)
				{
				plot.Add(string.Join("",item.ToCharArray().Skip(m).Take(n)));
				mark = false;
				}

				if (item=="|<")
				{
					mark = true;
				}

			}
			Console.WriteLine(string.Join(", ",plot));

		}
	}
}
