using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_TeamWork_Project
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Team> teams = new List<Team>();
			for (int i = 0; i < n; i++)
			{
				List<string> input = Console.ReadLine().Split('-').ToList();

				if (teams.Any(x => x.TeamName == input[1])) //if team exists
				{
					Console.WriteLine($"Team {input[1]} was already created!");
					
				}
				else
				{
					if (teams.Any(x => x.NameOfTeamCreator == input[0]))
					{
						Console.WriteLine($"{ input[0]} cannot create another team!");
						
					}
					else
					{
						Team myTeam = new Team();
						myTeam.NameOfTeamCreator = input[0];
						myTeam.TeamName = input[1];
						List<string> members = new List<string>();
						myTeam.TeamMembers = members;
					}
				}

				
				
			}

			string input2 = Console.ReadLine();
			while (input2 != "end of assignment")
			{
				string[] joiners = input2.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

				if (!teams.Any(x => x.TeamName == joiners[1]))
				{
					Console.WriteLine($"Team { joiners[1]} does not exist!");
				}
				else if (teams.Any(x=>x.TeamMembers.Contains(joiners[0])) ||
							teams.Any(x => x.NameOfTeamCreator == joiners[0]))
				{
					Console.WriteLine($"Member { joiners[0]} cannot join team { joiners[1]}");
				}

				input2 = Console.ReadLine();
			}

			foreach (var squad in teams.Where(x=> x.TeamMembers.Count !=0)
			.OrderByDescending(x=>x.TeamMembers)
			.ThenBy(x=>x.TeamName)
			)
			{
				Console.WriteLine(squad.TeamName.OrderBy(x=>x));
				Console.WriteLine("- "+squad.NameOfTeamCreator);

				foreach (var member in squad.TeamMembers)
				{
					Console.WriteLine("-- "+member);
				}
			}

			Console.WriteLine("Teams to disband:");
			foreach (var squad in teams.Where(x=> x.TeamMembers.Count ==0).OrderBy(x=>x.TeamName))
			{
				Console.WriteLine($"{squad.TeamName}");
			}

		}
	}

	class Team
	{
		public string TeamName{ get; set; }
		public List<string> TeamMembers { get; set; }
		public string NameOfTeamCreator { get; set; }

	}


}
