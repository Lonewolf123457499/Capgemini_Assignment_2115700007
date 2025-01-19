using System;
class Average
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the  first number");
		int a=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the second number");
		int b=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the third number");
		int c=Convert.ToInt32(Console.ReadLine());
		
		double average=(a+b+c)/3;
		
		Console.WriteLine("Average of three number is "+average);
	}
}
