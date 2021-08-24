using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Find_Substring
{
	class Program
	{
		static void Main(string[] args)
		{

			string input = Console.ReadLine().ToLower();
			string subStr = Console.ReadLine().ToLower();

			int counter = 0;
			int index = -1;

			while (true)
			{
				index = input.IndexOf(subStr, index + 1);
				if (index == -1)
				{
					break;
				}
				else
				{
					counter++;
				}
				
			}
			Console.WriteLine(counter);
		}
	}
}
