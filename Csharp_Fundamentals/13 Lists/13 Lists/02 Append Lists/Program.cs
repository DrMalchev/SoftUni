using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Append_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> inp = Console.ReadLine()
				.Split('|')
				.ToList();

			inp.Reverse();

			foreach (var item in inp)
			{
				string[] textArr = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				string joined = string.Join(" ", textArr);
				Console.Write(joined+" ");
			}
			Console.WriteLine();


		}
	}
}
