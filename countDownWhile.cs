using System;
class WhileCountDown
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the counter value");
		int counter=int.Parse(Console.ReadLine());
		while(counter>=1)
		{
			Console.WriteLine("counter value "+counter);
			counter--;
		}
	}
}
