using System;
using System.Numerics;


namespace _03_Big_Power
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			
			//alternative 1
			//BigInteger n=1;
			//for (int i = 0; i < a; i++)
			//{
			//	n = n * a;
			//}
			//Console.WriteLine(n);

			//alternative 2
			Console.WriteLine(BigInteger.Pow(a,a));


		}
	}
}
