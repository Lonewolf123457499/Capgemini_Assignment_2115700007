using System;
class NumberCheck
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the number");
		int num=int.Parse(Console.ReadLine());
		if(num>0)
		{
			Console.WriteLine("Positive");
		}
		else if(num<0)
		{
			Console.WriteLine("Negative");
		}
		else
		{
			Console.WriteLine("Zero");
		}
		
			
	}
}
		