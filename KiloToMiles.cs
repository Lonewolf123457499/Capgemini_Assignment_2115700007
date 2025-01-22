using System;
class Kilometer_To_Miles
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the distance in kilometer");
		double km=Convert.ToDouble(Console.ReadLine());
		double miles=km*0.625;
		Console.WriteLine("The total miles is "+miles+ "mile for the given "+km+"km");
	}
}

		