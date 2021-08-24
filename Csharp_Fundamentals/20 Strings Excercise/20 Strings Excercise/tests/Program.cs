using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_Big_Integer
{
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger n1 = BigInteger.Parse(Console.ReadLine());
			BigInteger n2 = BigInteger.Parse(Console.ReadLine());

			BigInteger sum = n1 + n2;
			Console.WriteLine(sum);

		}
	}
}
