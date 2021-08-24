using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Index_of_Letters
{
	class Program
	{
		static void Main(string[] args)
		{

			char[] word = Console.ReadLine().Select(x => ""+x).Select(x => char.Parse(x)).ToArray();

			for (int i = 0; i < word.Length; i++)
			{
				Console.WriteLine(word[i] + " -> " + (word[i] - 'a'));
			}
		}
	}
}
