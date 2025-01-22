using System;
class Volume_Of_Earth
{
	public static void Main(string[] args)
	{
		int radius_of_earth=6378;
		double volume_km=(4*3.14*radius_of_earth*radius_of_earth*radius_of_earth)/3;
		double km_miles=6378*0.621371;
		double volume_miles=(4*3.14*km_miles*km_miles*km_miles)/3;
		Console.WriteLine("The volume of earth in cubic kilometer is "+volume_km+" and  cubic miles is "+volume_miles);
	}
}

		