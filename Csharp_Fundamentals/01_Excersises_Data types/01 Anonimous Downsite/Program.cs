using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _01_Anonimous_Downsite
{
	class Program
	{
		static void Main(string[] args)
		{
			sbyte n = sbyte.Parse(Console.ReadLine());
			sbyte key = sbyte.Parse(Console.ReadLine());
			string sitename;

			decimal loss = 0m;
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				string[] splited = input.Split(' ').ToArray();

				sitename = splited[0];
				uint SiteVisits = uint.Parse(splited[1]);
				decimal Price = decimal.Parse(splited[2]);
				loss = loss + Price * SiteVisits;

				Console.WriteLine(sitename);
			}
			Console.WriteLine($"Total Loss: {loss:F20}");
			Console.WriteLine($"Security Token: {BigInteger.Pow(key,n)}");

		}
	}
}
