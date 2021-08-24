using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_Key_Replacer
{
	class Program
	{
		static void Main(string[] args)
		{
			string keyStr = Console.ReadLine();
			string text = Console.ReadLine();
			string pattern = @"(?m)^([a-zA-Z]{0,})(?=[\\,<,|])|((?<=[\|<\\])[a-zA-Z]{0,})$";

			var result = Regex.Matches(keyStr, pattern);
			List<string> keys = new List<string>();

			foreach (Match item in result)
			{
				keys.Add(item.Value);
			}
			if (keys.Count!=2)
			{
				Console.WriteLine("Empty result");
				return;
			}
			string pattern2 = keys[0]+"(?!"+ keys[1] + ")(.*?)"+ keys[1];
			//string pattern2 = keys[0] + @"(.*?)" + keys[1];
			var result2 = Regex.Matches(text, pattern2);
			List<string> plot = new List<string>();

			foreach (Match item in result2)
			{
				plot.Add(item.Groups[1].Value);


			}

			if (Regex.IsMatch(text,pattern2))
			{
			Console.WriteLine(string.Join("",plot));
			}
			else
			{
				Console.WriteLine("Empty result");
			}
		}

	}
}
