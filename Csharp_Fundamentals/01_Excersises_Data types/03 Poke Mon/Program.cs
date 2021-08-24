using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Poke_Mon
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine()); //Poke Power 10
			int M = int.Parse(Console.ReadLine()); //Distance betwen targets 5
			int Y = int.Parse(Console.ReadLine()); //2

			int Nstart = N; //10
			int poked = 0;
			do
			{
				N = N - M;
				poked = poked + 1;

				if (N == 0.5 * Nstart && Y!=0)
				{
					N = N / Y;
				}


			} while (N>=M);

			Console.WriteLine(N);
			Console.WriteLine(poked);


		}
	}
}
