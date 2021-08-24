using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Char_Multiplier
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> inp = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

			string word1 = inp[0];
			string word2 = inp[1];
			List<int> result = new List<int>();

			int diff = word1.Length - word2.Length;
			if (diff==0)
			{
				for (int i = 0; i < word1.Length; i++)
				{
					result.Add(word1[i] * word2[i]);
				}
			}
			else if (diff>0) //word1 is longer
			{
				var sb = new StringBuilder(word2);
				for (int i = 0; i < diff; i++)
				{
					sb.Append(1);
				}
				word2 = sb.ToString();

				for (int i = 0; i < word1.Length; i++)
				{
					if (word2[i] == '1')
					{
						result.Add(1 * word1[i]);
					}
					else
					{
						result.Add(word1[i] * word2[i]);
					}
				}
			}
			else
			{
				var sb = new StringBuilder(word1); //word1 is shorter
				for (int i = 0; i < Math.Abs(diff); i++)
				{
					sb.Append(1);
				}
				word1 = sb.ToString();

				for (int i = 0; i < word1.Length; i++)
				{
					if (word1[i]=='1')
					{
						result.Add(1 * word2[i]);
					}
					else
					{
						result.Add(word1[i] * word2[i]);
					}
				}
			}
			Console.WriteLine(string.Join("",result.Sum()));
			
		}
	}
}
