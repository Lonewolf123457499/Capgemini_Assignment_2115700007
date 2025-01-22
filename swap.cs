using System;
class Swap
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the two number");
		int num1=int.Parse(Console.ReadLine());
		int num2=int.Parse(Console.ReadLine());
		
		int temp=num1;
		num1=num2;
		num2=temp;
		
		Console.WriteLine(" The swapped numbers are "+num1+" and "+ num2);
	}
}


		