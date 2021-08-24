using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace tests
{
	class Program
	{
		static void Main(string[] args)
		{

			DateTime[] hollidays = new DateTime[11]
				{
			DateTime.ParseExact("07-04-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("03-01-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("01-05-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("06-05-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("24-05-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("06-09-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("22-09-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("01-11-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("24-12-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("25-12-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("26-12-2018","dd-MM-yyyy",CultureInfo.InvariantCulture)
			};

			//for (DateTime i = hollidays[0]; i < hollidays[1]; i=i.AddDays(01))
			//{
			//	Console.WriteLine(i);
			//}

			if (hollidays[0].DayOfWeek.ToString() == "Saturday")
			{

				Console.WriteLine("sat");
			}

		}
	}
}
