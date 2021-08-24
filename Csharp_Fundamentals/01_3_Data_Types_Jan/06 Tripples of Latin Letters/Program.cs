using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Tripples_of_Latin_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			char end = (char)((int)'a' + n-1);

			for (char i = 'a'; i <= end; i++)
			{
				for (char j = 'a'; j <= end; j++)
				{
					for (char k = 'a'; k <= end; k++)
					{
						Console.WriteLine($"{i}{j}{k}");
					}
				}
			}



		}
	}
}
