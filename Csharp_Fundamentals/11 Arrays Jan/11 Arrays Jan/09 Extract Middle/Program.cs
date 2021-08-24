using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Extract_Middle
{
	class Program
	{
		static void Main(string[] args)
		{

			string arrStr = Console
				.ReadLine();

			long[] arr = arrStr.Split(' ')
							.Select(long.Parse)
							.ToArray();

			if (arr.Length==1)
			{
				Console.WriteLine("{ "+arr[0]+" }");
			}
			else if (arr.Length%2==0) //even
			{
				int middle = arr.Length / 2;
				Console.WriteLine("{ " + arr[middle-1] + ", "+ arr[middle] + " }");

			}
			else
			{
				int middle = arr.Length / 2;
				Console.WriteLine("{ " + arr[middle - 1] + ", " + arr[middle] + ", " + arr[middle+1] + " }");
			}

		}
	}
}
