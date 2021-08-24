using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sales
{

	class Sale 
	{ 
		public string Town { get; set; }
		public string Product { get; set; }
		public decimal Price { get; set; }
		public double Quantity { get; set; }

	}


	class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());
			var sales = new SortedDictionary<string, List<Sale>>();
			for (int i = 0; i < n; i++)
			{
				var sale = ReadSale();


				if (!sales.ContainsKey(sale.Town))
				{
					sales[sale.Town] = new List<Sale>();
				}
					
				sales[sale.Town].Add(sale);
				
			}

			foreach (var saleByTown in sales)
			{
				var town = saleByTown.Key;
				var sumOfSales = saleByTown.Value.Sum(x => x.Price * (decimal)x.Quantity);

				Console.WriteLine($"{town} -> {sumOfSales:F2}");
			}
		}

		//methods

		static Sale ReadSale()
		{

			var saleParts = Console.ReadLine().Split(' ');

			return new Sale
			{
				Town = saleParts[0],
				Product = saleParts[1],
				Price = decimal.Parse(saleParts[2]),
				Quantity = double.Parse(saleParts[3])

			};
		}

	}
}
