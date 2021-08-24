using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hands_of_Cards
{
	class Program
	{
		static void Main(string[] args)
		{
			string draw = Console.ReadLine();
			Dictionary<string, string> players = new Dictionary<string, string>();
			
			List<string> powerStr = new List<string>();

			while (draw != "JOKER")
			{
				List<string> drawList = draw.Split(new char[] { ':'},StringSplitOptions.RemoveEmptyEntries).ToList();



				if (players.ContainsKey(drawList[0]) == false)
				{
					players.Add(drawList[0],drawList[1]);
				}
				else
				{
					players[drawList[0]] += drawList[1];
				}
				draw = Console.ReadLine();

			}
			//foreach (var item in players)
			//{
			//	Console.WriteLine(item.Key+" -> "+item.Value);
			//}
			//return;

			foreach (var pair in players)
				{
					powerStr = pair.Value.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
					powerStr = powerStr.Distinct().ToList();
					
					int[] powInt = new int[powerStr.Count];
					int[] colorInt = new int[powerStr.Count];

					string[] pow = new string[powerStr.Count];
					string[] color = new string[powerStr.Count];


				for (int i = 0; i < powerStr.Count; i++)
				//int i = 1; //test
				
					{
						string len = powerStr[i];
						pow = powerStr[i].Select(c => "" + c).Take(len.Length-1).ToArray();
						string pow2 = string.Join("",pow);
						color = powerStr[i].Select(c => "" + c).Reverse().Take(1).ToArray();

					
						if (pow[0] == "A")
						{
							powInt[i] = 14;
						}
						else if (pow[0] == "K")
						{
							powInt[i] = 13;
						}
						else if (pow[0] == "Q")
						{
							powInt[i] =12;
						}
						else if (pow[0] == "J")
						{
							powInt[i] = 11;
						}
						else
						{
							powInt[i] = int.Parse(pow2);
						}

						//color
						if (color[0]=="S")
						{
							colorInt[i] = 4;
						}
						else if(color[0] == "H")
						{
							colorInt[i] = 3;
						}
						else if (color[0] == "D")
						{
							colorInt[i] = 2;
						}
						else if (color[0] == "C")
						{
							colorInt[i] = 1;
						}
						else
						{
							Console.WriteLine("wrong color");
							return;
						}
					}
					//Console.WriteLine(string.Join(", ", powInt));
					//Console.WriteLine(string.Join(", ", colorInt));
					//Console.WriteLine(powerStr.Count);
					//break; //break for tests
					int[] powerEnd = new int[colorInt.Length];
					powerEnd = powInt.Select((x, y) => x * colorInt[y]).ToArray();
					
					Console.WriteLine(pair.Key + ": "+ powerEnd.Sum());
				}

				//break; //break for tests

			

			//foreach (var pair in players)
			//{
			//	Console.WriteLine(pair.Key +" -> "+ pair.Value);
			//}

			//Console.WriteLine(string.Join(" ", powerStr));

		}
	}
}
