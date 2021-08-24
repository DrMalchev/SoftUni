using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Multiply_Big_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string n1 = Console.ReadLine();
			int n2 = int.Parse(Console.ReadLine());

			if (n2==0)
			{
				Console.WriteLine(0);
				return;
			}

			List<int> result = new List<int>();
			int numRem = 0;

			for (int i = n1.Length - 1; i >= 0; i--)
			{
				int n1Int = int.Parse(n1[i].ToString());
				int numAdd = (numRem + (n2 * n1Int)) %10; //1
				numRem = (numRem + (n2 * n1Int)) / 10; //8

				result.Add(numAdd); //1
			}
			result.Add(numRem);
			result.Reverse();
			
			Console.WriteLine(string.Join("",result).TrimStart('0'));
		}
	}
}
//3695388955727932769851328408
