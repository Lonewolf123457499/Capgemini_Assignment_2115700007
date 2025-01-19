using System;
class SimpleIntrest
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the principal amount");
		int principal=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the rate interest ");
		double rate=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the time ");
		double time=Convert.ToInt32(Console.ReadLine());
		
		double simple_interest= (principal*rate*time)/100;
		
		Console.WriteLine("The simple interest is "+simple_interest);
	}
}
		