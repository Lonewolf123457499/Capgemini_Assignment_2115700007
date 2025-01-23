using System;
class DivisibleByFive
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the number");
		int num=int.Parse(Console.ReadLine());
		string result=(num%5==0)?"YES":"NO";
		Console.WriteLine("Is the number "+num+" divisible by 5?"+result);
	}
}
