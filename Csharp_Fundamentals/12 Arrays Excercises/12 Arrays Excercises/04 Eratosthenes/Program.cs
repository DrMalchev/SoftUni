using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Eratosthenes
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			if (n == 1 || n == 0 || n < 0)
			{
				Console.WriteLine();


				return;
			}
					

			bool[] primes = new bool[n+1];
			for (int i = 0; i < primes.Length; i++)
			{
				primes[i] = true;
			}

			primes[0] = false;
			primes[1] = false;
			int p=2;

			

			while (p<=n)
			{
				if (primes[p]==true)
				{   //p=2 2p=4 3p=6 4p=8
					//p=3 2p=6 3p=9 4p=12
					//p=4 2p=8 3p=12 4p=16

					for (int i = 1; i <= n; i++)
					{
						if (i/p>=2 && i%p==0)
						{
							primes[i] = false;
						}
					}
				}
			
				p++;
			}

			for (int i = 0; i <= n; i++)
			{
				if (primes[i]==true)
				{
					Console.Write(i+" ");
				}
			}
		}
	}
}
