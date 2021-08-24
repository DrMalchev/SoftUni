using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Randomize_Words
{
	class Program
	{
		static void Main(string[] args)
		{

			var input = Console.ReadLine().Split(' ').ToList();
			//Console.WriteLine(string.Join(" ", input));
			int n = input.Count;
			for (int i = 0; i < n; i++)
			{
				var rnd = new Random().Next(0,input.Count);
						
				Console.WriteLine(input[rnd]);
				input.RemoveAt(rnd);
			}

		}
	}
}
