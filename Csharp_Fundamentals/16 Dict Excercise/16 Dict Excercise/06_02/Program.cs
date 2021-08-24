using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02
{
	class Program
	{
		static void Main(string[] args)
		{

			string site = Console.ReadLine();
			string user;
			string ip;

			Dictionary<string, Dictionary<string, int>> userDict= new Dictionary<string, Dictionary<string, int>>();
			Dictionary<string, int> ipDict = new Dictionary<string, int>();
			while (site!="end")
			{
				List<string> input = site.Split(' ').ToList();
				List<string> userList = input[2].Split('=').ToList();
				List<string> ipList = input[0].Split('=').ToList();

				user = userList[1];
				ip = ipList[1];

				if (userDict.ContainsKey(user) == false)
				{
					ipDict = new Dictionary<string, int>();
					ipDict.Add(ip, 1);

					userDict.Add(user, ipDict);
				}
				else
				{
					if (userDict[user].ContainsKey(ip) == false)
					{
						userDict[user].Add(ip, 1);
					}
					else
					{
						userDict[user][ip] += 1;
					}

				}


				site = Console.ReadLine();
			}


			foreach (var pair in userDict.OrderBy(x => x.Key))
			{
				List<string> helper = new List<string>();
				Console.WriteLine($"{pair.Key}: ");
				foreach (var pair2 in userDict[pair.Key])
				{
					helper.Add($"{pair2.Key} => {pair2.Value}");
				}
				string print = string.Join(", ", helper);
				//print.Remove(print.Length-3);
				Console.Write(print+". ");
				Console.WriteLine();
			}

		}
	}
}
