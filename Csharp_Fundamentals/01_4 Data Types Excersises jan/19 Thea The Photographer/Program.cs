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
			ulong uploadTimeperPicture= ulong.Parse(Console.ReadLine());

			double filteredPictures = Math.Ceiling(numPictures * percentage / 100.0);
			double filterTime = numPictures * filterTimePerPicture;
			double uploadTime = filteredPictures * uploadTimeperPicture;
			double totalTime = filterTime + uploadTime;
			//1600sec
			double min = totalTime / (60.0); //26.6666min
			double hours = min / (60.0); //0,44444h
			double days = hours / 24.0; //0,0185185 days
			
			ulong daysPrint = (ulong)Math.Floor(days); //0
			ulong hoursPrint = (ulong)Math.Floor((days-daysPrint)*24.0); //0 (0,4444h)
			if (hoursPrint == 24)
			{
				daysPrint = daysPrint + 1;
			}
			double temp = ((days - daysPrint) * 24.0); // 0.444444444h
			ulong minPrint = (ulong)Math.Floor((temp-hoursPrint)*60.0); //26
			if (minPrint==60)
			{
				hoursPrint = hoursPrint + 1;
			}
			temp = ((temp - hoursPrint) * 60.0); //26,66666
			ulong secPrint = (ulong)Math.Round((temp-minPrint)*60); //39.99
			if (secPrint == 60)
			{
				minPrint = minPrint + 1;
			}
			

			Console.WriteLine($"{daysPrint}:{hoursPrint:D2}:{minPrint:D2}:{secPrint:D2}");

		}
	}
}
