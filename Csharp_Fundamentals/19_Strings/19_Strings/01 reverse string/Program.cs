using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_reverse_string
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] charArr = Console.ReadLine().ToCharArray();
			Array.Reverse(charArr);
			Console.WriteLine(charArr);

		}
	}
}
