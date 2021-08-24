using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Text_Filter
{
	class Program
	{
		static void Main(string[] args)
		{

			string input1 = Console.ReadLine();
			string text = Console.ReadLine();

			List<string> banList = input1.Split(", "
			.ToCharArray(),StringSplitOptions
			.RemoveEmptyEntries)
			.ToList();

			
			string[] asterixList = new string[banList.Count];
			
			for (int i = 0; i < banList.Count; i++)
			{
				asterixList[i] =  new string('*',banList[i].Length);
				text = text.Replace(banList[i], asterixList[i]);
			}

			Console.WriteLine(text);
			

		}
	}
}
