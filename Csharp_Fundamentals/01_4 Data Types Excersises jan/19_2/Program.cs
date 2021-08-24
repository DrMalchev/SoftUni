using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Thea_The_Photographer
{
	class Program
	{
		static void Main(string[] args)
		{
			ulong numPictures = ulong.Parse(Console.ReadLine());
			ulong filterTimePerPicture = ulong.Parse(Console.ReadLine());
			ulong percentage = ulong.Parse(Console.ReadLine());
			ulong uploadTimeperPicture = ulong.Parse(Console.ReadLine());

			double filteredPictures = Math.Ceiling(numPictures * percentage / 100.0);
			double filterTime = numPictures * filterTimePerPicture;
			double uploadTime = filteredPictures * uploadTimeperPicture;
			double totalTime = filterTime + uploadTime;

			TimeSpan t = TimeSpan.FromSeconds(totalTime);

			string output = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
							t.Days,
							t.Hours,
							t.Minutes,
							t.Seconds);
			Console.WriteLine(output);


		}
	}
}
