using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reverse_Array_of_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] strings = Console
						.ReadLine().Split(' ');

			//var reversed = strings.Reverse();
			string[] reversed = strings.Reverse().ToArray();


			foreach (var item in reversed)
			{
				Console.Write(item + " ");
			}
		}
	}
}
