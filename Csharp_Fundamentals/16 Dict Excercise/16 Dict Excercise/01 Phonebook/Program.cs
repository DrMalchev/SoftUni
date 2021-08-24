using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Phonebook
{
	class Program
	{
		static void Main(string[] args)
		{
			string start = Console.ReadLine();
			Dictionary<string, string> phonebook = new Dictionary<string, string>();
			List<string> input = new List<string>();

			while (start != "END")
			{
				input = start.Split(' ').ToList();
				
				if (input[0] == "A")
				{
					if (phonebook.ContainsKey(input[1]) == false)
					{
						phonebook.Add(input[1], input[2]);
					}
					else
					{
						phonebook[input[1]] = input[2];
					}

				}
				else if (input[0] == "S")
				{
					if (phonebook.ContainsKey(input[1]) == false)
					{
						Console.WriteLine($"Contact {input[1]} does not exist.");
					}
					else
					{
						Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
					}
				}

				start = Console.ReadLine();
			}



		}
	}
}
