using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Employee_Data
{
	class Program
	{
		static void Main(string[] args)
		{
			String firstName = Console.ReadLine();
			String lastName = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			char sex = char.Parse(Console.ReadLine());
			long pID = long.Parse(Console.ReadLine());
			long eID = long.Parse(Console.ReadLine());

			Console.WriteLine($"First name: {firstName}");
			Console.WriteLine($"Last name: {lastName}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Gender: {sex}");
			Console.WriteLine($"Personal ID: {pID}");
			Console.WriteLine($"Unique Employee number: {eID}");

		}
	}
}
