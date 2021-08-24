using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Magic_Exchangable_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> inp = Console.ReadLine().Split(' ').ToList();
			string word1 = inp[0];
			string word2 = inp[1];

			var unique1 = string.Join("", word1.ToCharArray().Distinct());
			var unique2 = string.Join("", word2.ToCharArray().Distinct());

			if (unique1.Length == unique2.Length)
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}


		}
	}
}

//Clint Eastwood