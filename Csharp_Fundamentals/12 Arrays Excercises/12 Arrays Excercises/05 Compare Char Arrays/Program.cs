using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] row1 = Console
				.ReadLine()
				.Split(' ')
				.Select(s => char.Parse(s))
				.ToArray();
			char[] row2 = Console
				.ReadLine()
				.Split(' ')
				.Select(s => char.Parse(s))
				.ToArray();

			char[] zero = {'0' };
			char[] check1= row1.Concat(zero).ToArray();
			char[] check2 = row2.Concat(zero).ToArray();


			int n = Math.Min(row1.Length, row2.Length);
			string bigger = "na";
			for (int i = 0; i < n+1; i++)
			{
				if (check1[i]!=check2[i])
				{
					if (check1[i]>check2[i])
					{
						bigger = "row1";
						
					}
					break;
				}
			}
			
			//if (bigger=="na" && row1.Length > row2.Length)
			//{
			//	Console.WriteLine(string.Join("", row1));
			//	Console.WriteLine(string.Join("", row2));
			//	return;
			//}
			//else if (bigger == "na" && row1.Length < row2.Length)
			//{
			//	Console.WriteLine(string.Join("", row2));
			//	Console.WriteLine(string.Join("", row1));
			//	return;
			//}


			if (bigger=="row1")
			{
				Console.WriteLine(string.Join("", row2));
				Console.WriteLine(string.Join("", row1));
			}
			else if (bigger=="na")
			{
				Console.WriteLine(string.Join("", row1));
				Console.WriteLine(string.Join("", row2));
			}

		}
	}
}
