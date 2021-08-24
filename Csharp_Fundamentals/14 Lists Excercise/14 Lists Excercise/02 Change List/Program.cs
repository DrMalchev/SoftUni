using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Change_List
{
	class Program
	{
		static void Main(string[] args)
		{

			List<int> nums = Console.ReadLine()
				.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			string com = Console.ReadLine().ToLower();

			while (com!="odd" && com!="even")
			{

				string[] comStr = com.Split(' ');
				int arg1 = int.Parse(comStr[1]);
				int arg2 = 0;
				if (comStr[0]=="insert")
				{
					arg2 = int.Parse(comStr[2]);

				}
				
				switch (comStr[0])
				{
					case "delete":
						nums.RemoveAll(x => x == arg1);
						//nums.Remove(arg1);
						break;
					case "insert":
						nums.Insert(arg2,arg1);
						break;

				}
				string comW = Console.ReadLine().ToLower();
				if (comW.Length<=4)
				{
					com = comW;
					break;
					
				}
				com = comW;
			}

			if (com == "even")
			{
				Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 == 0).ToList()));
			}
			else if (com == "odd")
			{
				Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 != 0).ToList()));
			}
			else
			{
				//do nothing
			}

		}


	}
}
