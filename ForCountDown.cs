using System;
class WhileCountDown
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the counter value");
		int counter=int.Parse(Console.ReadLine());
		for(int i=counter;i>=1;i--)
		{
			Console.WriteLine("counter value "+counter);
		}
	}
}
