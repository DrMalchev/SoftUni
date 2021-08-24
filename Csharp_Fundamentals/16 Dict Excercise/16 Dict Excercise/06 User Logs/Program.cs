using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_User_Logs
{
	class Program
	{
		static void Main(string[] args)
		{

			string input = Console.ReadLine();
			SortedDictionary<string, List<string>> userIp = new SortedDictionary<string, List<string>>();
			SortedDictionary<string, int> ipCount = new SortedDictionary<string, int>();
			List<string> ipsList = new List<string>(0);

			while (input!="end")
			{
				
				List<string> div1 = input.Split(new char[] { '=', ' ' }).ToList();
				string ip = div1[1];
				string user = div1[5];
				

				if (userIp.ContainsKey(user) == false)
				{
					ipsList = new List<string>(0);
					if (ipCount.ContainsKey(ip) == false)
					{
						
						ipsList.Add(ip);
						userIp.Add(user,ipsList);
						ipCount.Add(ip, 1);

					}
					else
					{
						ipCount[ip]+=1;
					}
				}
				else
				{
					if (ipCount.ContainsKey(ip) == false)
					{

						ipsList.Add(ip);
						ipCount.Add(ip, 1);

					}
					else
					{
						ipCount[ip] += 1;
					}
				}

				input = Console.ReadLine();
				
			}

			foreach (var pair in userIp)
			{
				Console.WriteLine(pair.Key + ": ");
				foreach (var pair2 in ipCount)
				{
					if (pair.Value.Contains(pair2.Key))
					{

					
					Console.Write(pair2.Key + " => " + pair2.Value);
					if (pair2.Key != pair.Value.Last())
					{
						Console.Write(", ");
					}
					else
					{
						Console.WriteLine(".");
					}

					}
				}
				//Console.WriteLine();
			}
		}
	}
}
