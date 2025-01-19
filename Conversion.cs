using System;
class Conversion
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the temperature in Celsius");
		double celsius=Convert.ToDouble(Console.ReadLine());
		double fahrenheit=(c*9/5)+32;
		Console.WriteLine("Temperature in Fahrenheit is "+fahrenheit);
	}
}