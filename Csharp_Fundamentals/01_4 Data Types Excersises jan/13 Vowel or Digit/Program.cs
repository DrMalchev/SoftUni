using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Vowel_or_Digit
{
	class Program
	{
		static void Main(string[] args)
		{
			char c = char.Parse(Console.ReadLine());

			if (c=='a' || c == 'o' || c == 'u' || c == 'e' || c == 'i')
			{
				Console.WriteLine("vowel");
			}
			else if (c-'0' >= 0 && c-'0'<=9)
			{
				
				Console.WriteLine("digit");
			}

			else
			{
				Console.WriteLine("other");
			}
		}
	}
}
