using System;
class Income
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the salary of a person");
		int salary=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the bonus of a person");
		int bonus=int.Parse(Console.ReadLine());
		int total_Income=salary+bonus;
		Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+" . Hence Total Income is INR "+total_Income);
	}
}
	