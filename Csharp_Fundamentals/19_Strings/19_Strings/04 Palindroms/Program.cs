using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindroms
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(" ,.?!".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToList();
			List<string> palindromes = new List<string>();

			foreach (var word in input)
			{
				if (isPalindrome(word) == true)
				{
					palindromes.Add(word);
				}
			}

			Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x=>x)));

		}

		static bool isPalindrome(string word)
		{
			int n = word.Length / 2;
			string left = word.Substring(0,n);
			if (word.Length%2==0)
			{
				word = word.Remove(0, n);
				char[] wordC = word.ToCharArray();
				Array.Reverse(wordC);
				word = string.Join("", wordC);

				if (word==left)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				word = word.Remove(0, n+1);
				char[] wordC = word.ToCharArray();
				Array.Reverse(wordC);
				word = string.Join("", wordC);
				if (word == left)
				{
					return true;
				}
				else
				{
					return false;
				}

			}



			
		}
	}
}
