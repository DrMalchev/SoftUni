using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Special_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				double i2 = i;
				string ii = i.ToString();
				double[] sum = new double[ii.Length];
				
				for (int j = 0; j < ii.Length; j++)
				{
					sum[j] = i2%10.0;
					i2 = Math.Floor(i2 / 10.0);


				}
				if (sum.Sum() == 5 || sum.Sum() == 7 || sum.Sum() == 11)
				{
					Console.WriteLine($"{i} -> True");
				}
				else
				{
					Console.WriteLine($"{i} -> False");
				}


			}



		}
	}
}
