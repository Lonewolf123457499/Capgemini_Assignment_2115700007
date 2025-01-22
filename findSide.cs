using System;
class Find_Sqaure_Side
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the perimeter of a sqaure");
		int perimeter=Convert.ToInt32(Console.ReadLine());
		double side=perimeter/4;
		Console.WriteLine("The length of the side is "+side+" whose perimeter is"+perimeter);
	}
}