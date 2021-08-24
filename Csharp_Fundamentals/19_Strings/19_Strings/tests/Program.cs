using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = "abc";
			char [] wordC = word.ToCharArray();
			Array.Reverse(wordC);
			word = string.Join("",wordC);

			Console.WriteLine(wordC);

		}
	}
}
