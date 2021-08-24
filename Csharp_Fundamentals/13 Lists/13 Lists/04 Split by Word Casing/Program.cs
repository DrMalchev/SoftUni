using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Split_by_Word_Casing
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> words = Console.ReadLine()
				.Split(new char[] {',', ';', ':', '.', '!', '(', ')', '"', '\'','/','\\','[', ']', ' '}, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			List<string> upper = new List<string>();
			List<string> lower = new List<string>();
			List<string> other = new List<string>();


			foreach (var item in words)
			{
				bool isUpper = false;
				bool isLower = false;

				for (int i = 0; i < item.Length; i++)
				{
					if (item[i]>=65 && item[i]<=90) //upper
					{
						isUpper = true;
					}
					else
					{
						isUpper = false;
						break;
					}
				}

				for (int i = 0; i < item.Length; i++) //lower
				{
					if (item[i] >= 97 && item[i] <= 122)
					{
						isLower = true;
					}
					else
					{
						isLower = false;
						break;
					}
				}

				if (isUpper)
				{
					upper.Add(item);
				}
				else if (isLower)
				{
					lower.Add(item);
				}
				else
				{
					other.Add(item);

				}


			}
			Console.WriteLine("Lower-case: " + string.Join(", ",lower));
			Console.WriteLine("Mixed-case: " + string.Join(", ",other));
			Console.WriteLine("Upper-case: " + string.Join(", ",upper));

		}
	}
}
