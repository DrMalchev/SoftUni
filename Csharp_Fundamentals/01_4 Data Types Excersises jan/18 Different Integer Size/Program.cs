using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Different_Integer_Size
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = (Console.ReadLine());
			double n = Convert.ToDouble(input);
			bool sb=false;
			bool by = false;
			bool sh = false;
			bool us = false;
			bool iN = false;
			bool uiN = false;
			bool lo = false;
			bool big = false;

			if (n!=Math.Floor(n))
			{
				Console.WriteLine($"{input} can't fit in any type");
				return;
			}
			

			if (n>=sbyte.MinValue && n<=sbyte.MaxValue)
			{
				sb = true;
			}
			if (n >= byte.MinValue && n <= byte.MaxValue)
			{
				 by = true;
			}
			if (n >= short.MinValue && n <= short.MaxValue)
			{
				 sh = true;
			}
			if (n >= ushort.MinValue && n <= ushort.MaxValue)
			{
				 us = true;
			}
			if (n >= int.MinValue && n <= int.MaxValue)
			{
				 iN = true;
			}
			if (n >= uint.MinValue && n <= uint.MaxValue)
			{
				 uiN = true;
			}
			if (n >= long.MinValue && n <= long.MaxValue)
			{
				 lo = true;
			}
			if (n>long.MaxValue || n<long.MinValue)
			{
				 big = true;
			}

			if (!big)
			{
				Console.WriteLine($"{input} can fit in:");
			}


			if (sb==true)
				{
				
				Console.WriteLine("* sbyte");
				}
				if (by==true)
				{
					
					Console.WriteLine("* byte");
				}
				if (sh==true)
				{
					
					Console.WriteLine("* short");
				}
				if (us==true)
				{
					
					Console.WriteLine("* ushort");
				}
				if (iN==true)
				{
					
					Console.WriteLine("* int");
				}
				if (uiN==true)
				{
					
					Console.WriteLine("* uint");
				}
				if (lo==true)
				{
					
					Console.WriteLine("* long");
				}
				
			
			if (big==true)
			{
				Console.WriteLine($"{input} can't fit in any type");
			}

		}
	}
}
