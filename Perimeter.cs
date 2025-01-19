using System;
class Perimeter
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter length ");
		int length=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter width ");
		int width=Convert.ToInt32(Console.ReadLine());
		
		int perimeter=2*(length+width);
		
		Console.WriteLine("perimeter of rectangle is "+perimeter);
	}
}
