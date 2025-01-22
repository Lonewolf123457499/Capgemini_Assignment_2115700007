using System;
class Area_Of_Triangle
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter height and base of triangle");
		double height=Convert.ToDouble(Console.ReadLine());
		double basee=Convert.ToDouble(Console.ReadLine());
		
		double height_in_inches=height*0.394;
		double base_in_inches=basee*0.394;
		
		double area_in_centimeter=(basee*height)/2;
		double area_in_inches=(base_in_inches*height_in_inches)/2;
		
		Console.WriteLine("Your Area in cm is "+ area_in_centimeter+" and in inches "+area_in_inches);
	}
}
		