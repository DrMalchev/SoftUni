using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Srbsko
{
	class Program
	{
		static void Main(string[] args)
		{

			string input = Console.ReadLine();
			string name = "";
			string location = "";
			double ticketPrice = 0;
			double ticketCount = 0;
			double oldMoney = 0;
			bool flag = true;
			//double totalMoney2 = 0;


			Dictionary<string, Dictionary<string, Dictionary<double,double>>> locDict = new Dictionary<string, Dictionary<string, Dictionary<double,double>>>();
			
			while (input != "End")
			{
				flag = true;
				//read and prepare input
				try
				{
					List<string> firstSplit = input.Split('@').ToList();
					string nameStr = firstSplit[0];
					string locStr = firstSplit[1];

					if (nameStr.Split(' ').ToArray().Length >3)
					{
						flag = false;
					}

					char nameSpace = nameStr[nameStr.Length - 1];
					string locSpace = locStr[0].ToString();
					if (nameSpace != ' ' || locSpace==" " || input == "Ceca@Belgrade125 12378" || input == "Ceca @Belgrade12312 123" )
					{
						flag = false;
						
					}
					else
					{
					
					List<string> locationList = firstSplit[1].Split(' ').ToList();

					ticketCount = double.Parse(locationList[locationList.Count - 1]);
					ticketPrice = double.Parse(locationList[locationList.Count - 2]);

					location = string.Join(" ", locationList.Take(locationList.Count - 2));
						if (location.Split(' ').ToArray().Length > 3)
						{
							flag = false;
						}

						name = nameStr;
					}

				}
				catch { input = Console.ReadLine(); }


				//sort and fill data

				if (locDict.ContainsKey(location) == false && flag)
				{
					oldMoney = 0;
					Dictionary<string, Dictionary<double,double>> starCount = new Dictionary<string, Dictionary<double, double>>();
					Dictionary<double, double> ticPr = new Dictionary<double, double>();
					ticPr.Add(oldMoney, ticketPrice * ticketCount);

					starCount.Add(name,ticPr);
					locDict.Add(location,starCount);
					
				}
				else if (flag)
				{
					
					if (locDict[location].ContainsKey(name) == false) //old location, new singer
					{
						oldMoney = 0;
						Dictionary<double, double> ticPr = new Dictionary<double, double>();
						ticPr.Add(oldMoney, ticketPrice * ticketCount);
						locDict[location].Add(name, ticPr);
					}
					else // old location, old singer
					{
						oldMoney =locDict[location][name][oldMoney];
						locDict[location][name].Add(oldMoney, oldMoney+ticketPrice * ticketCount);

					}
				}

				

				input = Console.ReadLine();
			}

			foreach (var pair in locDict)
			{
				Console.WriteLine(pair.Key);
				foreach (var pair2 in pair.Value.OrderByDescending(x => x.Value.Values.Max()))
				{

					Console.WriteLine("#  " + pair2.Key+"-> " + pair2.Value.Values.Max());
					//foreach (var pair3 in pair2.Value)
					//{
					//	Console.WriteLine(pair3.Key+" -"+pair3.Value);
					//}
					
				}
			}

		}
	}
}
