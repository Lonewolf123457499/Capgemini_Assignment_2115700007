using System;
class Above_18
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the voter age");
		int age=int.Parse(Console.ReadLine());
		if(age>=18)
		{
			Console.WriteLine("The person's age is "+age+" and can vote.");
		}
		else
		{
			Console.WriteLine("The person's age is "+age+" and cannot vote.");
		}
	}
}
		