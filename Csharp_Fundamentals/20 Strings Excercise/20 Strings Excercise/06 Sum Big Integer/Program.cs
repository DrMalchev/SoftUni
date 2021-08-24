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
			string n1 = Console.ReadLine();
			string n2 = Console.ReadLine();
			int[] result= new int[Math.Max(n1.Length,n2.Length)];
			string plot = "";

			int diff = n1.Length - n2.Length;
			if (diff==0)
			{
				int naum=0;
				for (int i = n1.Length-1; i >=0 ; i--)
				{
					result[i] = naum+int.Parse(n1[i].ToString())+int.Parse(n2[i].ToString());
					naum = 0;
					if (result[i] > 9)
					{
						naum = result[i] / 10;
						result[i] = result[i] % 10;
						
					}
				}
				if (naum!=0)
				{
					plot = naum.ToString() + string.Join("", result);
				}
				else
				{
					plot = string.Join("", result);
				}
				
				
			}
			else if (diff>0) //n1 > n2
			{
				int diff2 = n2.Length;
				n2 = n2.PadLeft(diff+diff2, '0');
				//start copy
				int naum = 0;
				for (int i = n1.Length - 1; i >= 0; i--)
				{	
					result[i] = naum + int.Parse(n1[i].ToString()) + int.Parse(n2[i].ToString());
					naum = 0;
					if (result[i] > 9)
					{
						naum = result[i] / 10;
						result[i] = result[i] % 10;
						
					}
				}
				if (naum != 0)
				{
					plot = naum.ToString() + string.Join("", result);
				}
				else
				{
					plot = string.Join("", result);
				}
				//end
			}
			else //n1 < n2
			{
				diff = diff * -1;
				int diff2 = n1.Length;
				n1 = n1.PadLeft(diff + diff2, '0');
				//start copy
				int naum = 0;
				for (int i = n1.Length - 1; i >= 0; i--)
				{
					result[i] = naum + int.Parse(n1[i].ToString()) + int.Parse(n2[i].ToString());
					naum = 0;
					if (result[i] > 9)
					{
						naum = result[i] / 10;
						result[i] = result[i] % 10;
						
					}
				}
				if (naum != 0)
				{
					plot = naum.ToString() + string.Join("", result);
				}
				else
				{
					plot = string.Join("", result);
				}
				//end
			}
			Console.WriteLine(plot.TrimStart('0'));
		}
	}
}
