using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fix_Emails
{
	class Program
	{
		static void Main(string[] args)
		{
			string start = Console.ReadLine();
			List<string> input = new List<string>();
			input.Add(start);

			while (start != "stop")
			{

				start = Console.ReadLine();
				input.Add(start);
			}
			input.RemoveAt(input.Count - 1);

			List<string> even = input.Where((x, i) => i % 2 == 0).ToList(); //index of array
			List<string> odd = input.Where((x, i) => i % 2 != 0).ToList(); //index of array

			List<string> temp = new List<string>();
			

			for (int i = 0; i < odd.Count; i++)
			{
				//temp = odd[i].Split('.').ToList();

				//if (temp[1] == "uk" ||
				//	temp[1] == "us")
				if (odd[i].EndsWith(".uk") || odd[i].EndsWith(".us"))
				{
					even.RemoveAt(i);
					odd.RemoveAt(i);	
				}
			}

			//Console.WriteLine(string.Join(" ", even));
			//Console.WriteLine(string.Join(" ", odd));

			for (int i = 0; i < even.Count; i++)
			{
				Console.WriteLine($"{even[i]} -> {odd[i]}");
			}

		}
	}
	
}
