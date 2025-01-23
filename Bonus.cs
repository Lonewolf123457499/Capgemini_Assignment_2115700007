using System;
class Bonus
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the salary of the Employee");
		int salary=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the year of Service");
		int yearOfService=int.Parse(Console.ReadLine());
		if(yearOfService>5)
		{
			int bonusAmount=(salary*5)/100;
			Console.WriteLine("Salary bonus Amount is "+bonusAmount);
		}
	}
}
