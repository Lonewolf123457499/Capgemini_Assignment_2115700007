using System;

class CelsiusToFahrenheit
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the temperature in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

       
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        
        Console.WriteLine("The "+celsius+" Celsius is "+fahrenheitResult+" Fahrenheit.");
    }
}
