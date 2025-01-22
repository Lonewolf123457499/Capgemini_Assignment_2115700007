using System;

class FahrenheitToCelsius
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

     
         Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsiusResult+" Celsius.");
    }
}
