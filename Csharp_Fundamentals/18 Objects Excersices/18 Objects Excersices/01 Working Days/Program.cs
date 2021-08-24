using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01_Working_Days
{
	class Program
	{
		static void Main(string[] args)
		{

			DateTime startDate = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",CultureInfo.InvariantCulture);

			DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
			int counterWorkingDays = 0;
			bool isHolliday = true;

			DateTime[] hollidays = 
			{
			DateTime.ParseExact("01-01-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
			DateTime.ParseExact("03-03-2018","dd-MM-yyyy",CultureInfo.InvariantCulture),
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
			
			for (DateTime i = startDate; i <= endDate; i=i.AddDays(1))
			{
				isHolliday = true;
				if (i.DayOfWeek.ToString() == "Saturday" || i.DayOfWeek.ToString() == "Sunday")
				{
					isHolliday = true;
					
					//counterWorkingDays++;
				}
				else
				{

						for (int j = 0; j < hollidays.Length; j++)
						{
							if (hollidays[j].Day == i.Day && hollidays[j].Month == i.Month)
							{
							isHolliday = true;
							break;
							
							//counterWorkingDays++;
							}
							else
							{
							isHolliday=false;
							
							}
						}
				}
				if (isHolliday==false)
				{
					counterWorkingDays++;
				}

			}
			Console.WriteLine(counterWorkingDays);
		}
	}

	//class Date
	//{
	//	public int Day { get; set; }
	//	public int Month { get; set; }
	//	public int Year{ get; set; }
	//}


}
