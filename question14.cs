using System;
class Factorial_While
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the number");
		int num=int.Parse(Console.ReadLine());
		int no=num;
		int fact=1;
		while(num>=1)
		{
			fact=fact*num;
			num--;
		}
		Console.WriteLine("factorial of "+no+" is "+fact);
		
	}
}