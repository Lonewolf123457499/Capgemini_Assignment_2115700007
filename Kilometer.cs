using System;
class Kilometer_Miles
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter kilometer");
		double kilometers=Convert.ToDouble(Console.ReadLine());
		double miles=kilometers*0.621371;
		
		Console.WriteLine("The distance in miles is "+miles);
	}
}

		