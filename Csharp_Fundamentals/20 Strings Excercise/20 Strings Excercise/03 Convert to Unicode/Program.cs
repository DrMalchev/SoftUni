using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Convert_to_Unicode
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			char[] inpArr = input.ToCharArray();

			foreach (var symbol in inpArr)
			{
				string converted = ((int)symbol).ToString("x4");
				Console.Write("\\u"+converted);
			}

		}
	}
}
