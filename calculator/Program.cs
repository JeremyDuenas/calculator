using System;

namespace calculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int input1;
			int input2;
			int sum;

			Console.WriteLine("Enter a number:");
			input1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter another number:");
			input2 = Convert.ToInt32(Console.ReadLine());
			sum = input1 + input2;
			Console.WriteLine("The sum of these two numbers is: {0}", sum);

		}
	}
}
