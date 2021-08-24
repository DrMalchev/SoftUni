using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strings_and_Objects
{
	class Program
	{
		static void Main(string[] args)
		{
			string hello = "Hello";
			string world = "World";
			object sumO = hello + " "+world;
			string sumS = (string)sumO;
			Console.WriteLine(sumS);
		}
	}
}
