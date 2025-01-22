using System;
class HeightConversion
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter your height");
		int height=Convert.ToInt32(Console.ReadLine());
		double inches=height/2.54;
		double feet=inches/12;
		Console.WriteLine("Your Height in cm is "+height+ " while in feet is "+feet+" and inches is "+inches);
	}
}