using System;

class DoubleOpt
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the value of a ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of b ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of c ");
        double c = Convert.ToDouble(Console.ReadLine());

        double result1 = a + b * c;     
        double result2 = a * b + c;     
        double result3 = c + a / b;     
        double result4 = a % b + c;      

        Console.WriteLine("The results of Int Operations are "+result1+","+result2+","+result3+","+result4);
		
		double value = 123.456789;
Console.WriteLine($"Value up to 2 decimal places: {value:F2}");
      
    }
}
