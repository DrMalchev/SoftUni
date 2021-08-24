using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01_Base_Concerter
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split(' ').ToList();
			int baseN = int.Parse(input[0]);
			BigInteger num = BigInteger.Parse(input[1]);
			int rem;
			List<int> converted = new List<int>();



			while (num>0)
			{
				rem = (int) (num % baseN);
				converted.Add(rem);
				num = num / baseN;

			}

			converted.Reverse();
			Console.WriteLine(string.Join("",converted));


		}
	}
}
