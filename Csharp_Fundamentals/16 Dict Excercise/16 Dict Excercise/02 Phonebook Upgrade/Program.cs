using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Phonebook_Upgrade
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
				else if (input[0] == "ListAll")
				{
					//var sortedList = phonebook.ToList();
					//sortedList.Sort((x, y) => x.Key.CompareTo(y.Key));
					//phonebook = sortedList.ToDictionary(x => x.Key, y => y.Value);
					

					foreach (var item in phonebook.OrderBy(x => x.Key))
					{
						Console.WriteLine($"{item.Key} -> {item.Value}");
					}


				}
				start = Console.ReadLine();

			}

		}
	}
}
