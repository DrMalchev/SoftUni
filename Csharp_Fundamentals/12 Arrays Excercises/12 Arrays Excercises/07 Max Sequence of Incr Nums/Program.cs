using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Max_Sequence
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int n = nums.Length;


			int counter = 0;
			int index = 1;
			int counterMax = 1;
			int indexMax = 1;
			bool doNothing = true;

			for (int i = n - 1; i >= 1; i--)
			{
				bool noZero = false;
				if (nums[i] - nums[i - 1] >=1)
				{
					counter++;
					index = i;
					noZero = true;
					doNothing = false;
				}
				if (counter >= counterMax)
				{
					counterMax = counter;
					indexMax = index;
					doNothing = false;
				}

				if (noZero == false)
				{
					counter = 0;
					//doNothing = false;
				}
			}

			if (doNothing)
			{
				//Console.WriteLine();
				return;
			}
			//Console.WriteLine(counterMax+1);
			//Console.WriteLine(indexMax-1);

			for (int i = (indexMax - 1); i < indexMax + counterMax; i++)
			{
				Console.Write(nums[i] + " ");
			}


		}
	}
}
