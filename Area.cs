using System;
class Area
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter radius of circle");
		int radius=Convert.ToInt32(Console.ReadLine());
		double area=3.14*radius*radius;
		Console.WriteLine("Area of circle  is "+area);
	}
}
		