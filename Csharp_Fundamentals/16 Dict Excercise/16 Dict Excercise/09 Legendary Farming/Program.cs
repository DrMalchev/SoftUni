using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Legendary_Farming
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine().ToLower();
			int shards = 0;
			int fragments = 0;
			int motes = 0;
			Dictionary<string, int> holderDict = new Dictionary<string, int>();
			holderDict.Add("shards",0);
			holderDict.Add("fragments", 0);
			holderDict.Add("motes", 0);

			while (shards<250 || fragments<250 || motes<250)
			{

				List<string> inputList = input.Split(' ').ToList();
				List<string> material = inputList.Where((x,i) => i % 2!=0).ToList();
				List<string> quantity = inputList.Where((x, i) => i % 2 == 0).ToList();

				for (int i = 0; i < material.Count; i++)
				{
					if (holderDict.ContainsKey(material[i])==false) //no such material
					{
						holderDict.Add(material[i], int.Parse(quantity[i]));
						if (holderDict["shards"]>=250 || holderDict["fragments"] >= 250 || holderDict["motes"] >= 250)
						{
							break;
						}
					}
					else
					{
						holderDict[material[i]] += int.Parse(quantity[i]);
						if (holderDict["shards"] >= 250 || holderDict["fragments"] >= 250 || holderDict["motes"] >= 250)
						{
							break;
						}
					}
				}

				if (holderDict["shards"] >= 250)
				{
					holderDict["shards"] -= 250;
					Console.WriteLine("Shadowmourne obtained!");

					foreach (var pair in holderDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
					{
						if (pair.Key == "shards"
						|| pair.Key == "fragments"
						|| pair.Key == "motes"
											)

						{
							Console.WriteLine($"{pair.Key}: {pair.Value}");
						}

					}
					foreach (var pair in holderDict.OrderBy(x => x.Key))
					{
						if (pair.Key != "shards"
							&& pair.Key != "fragments"
							&& pair.Key != "motes"
											)

						{
							Console.WriteLine($"{pair.Key}: {pair.Value}");
						}

					}
					return;
				}
				//copy 1
				if (holderDict["fragments"] >= 250)
				{
					holderDict["fragments"] -= 250;
					Console.WriteLine("Valanyr obtained!");

					foreach (var pair in holderDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
					{
						if (pair.Key == "shards"
						|| pair.Key == "fragments"
						|| pair.Key == "motes"
											)

						{
							Console.WriteLine($"{pair.Key}: {pair.Value}");
						}

					}
					foreach (var pair in holderDict.OrderBy(x => x.Key))
					{
						if (pair.Key != "shards"
							&& pair.Key != "fragments"
							&& pair.Key != "motes"
											)

						{
							Console.WriteLine($"{pair.Key}: {pair.Value}");
						}

					}
					return;
				}
						//end copy 1

						//copy 2
						if (holderDict["motes"] >= 250)
						{
							holderDict["motes"] -= 250;
							Console.WriteLine("Dragonwrath obtained!");

							foreach (var pair in holderDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
							{
								if (pair.Key == "shards"
								|| pair.Key == "fragments"
								|| pair.Key == "motes"
													)

								{
									Console.WriteLine($"{pair.Key}: {pair.Value}");
								}

							}

							foreach (var pair2 in holderDict.OrderBy(x => x.Key))
							{
								if (pair2.Key != "shards"
									&& pair2.Key != "fragments"
									&& pair2.Key != "motes"
													)

								{
									Console.WriteLine($"{pair2.Key}: {pair2.Value}");
								}

							}
					//end copy 2
					return;
						}


						input = Console.ReadLine().ToLower();
			}

		}
	}
}
