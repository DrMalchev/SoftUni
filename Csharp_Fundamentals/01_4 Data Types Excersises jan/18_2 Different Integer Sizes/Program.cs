using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_Different_Integer_Sizes
{
	class Program
	{
		static void Main(string[] args)
		{
			string n = Console.ReadLine();
			string message = "";
			bool isBig = true;

			try
			{
				sbyte num = sbyte.Parse(n);
				message = message + "* sbyte\r\n";
				isBig = false;
			}
			catch { }
			try
			{
				byte num = byte.Parse(n);
				message = message + "* byte\r\n";
				isBig = false;
			}
			catch { }
			try
			{
				short num = short.Parse(n);
				message = message + "* short\r\n";
				isBig = false;
			}
			catch { }
			try
			{
				ushort num = ushort.Parse(n);
				message = message + "* ushort\r\n";
				isBig = false;
			}
			catch { }
			try
			{
				int num = int.Parse(n);
				message = message + "* int\r\n";
				isBig = false;
			}
			catch { }
			try
			{
				uint num = uint.Parse(n);
				message = message + "* uint\r\n";
				isBig = false;
			}
			catch { }
			try
			{
				long num = long.Parse(n);
				message = message + "* long\r\n";
				isBig = false;
			}
			catch { }

			if (isBig)
			{
				Console.WriteLine($"{n} can't fit in any type");
			}
			else
			{
				Console.WriteLine($"{n} can fit in:");
				Console.WriteLine(message);
			}

		}
	}
}
