using System;
class Volume
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the radius of cylinder");
		double radius=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the height of cylinder");
		double height=Convert.ToDouble(Console.ReadLine());
		double volume=3.14*radius*radius*height;
		Console.WriteLine("Volume of cylinder is "+volume);
	}
}
		