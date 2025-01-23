using System;
class MultiplicationTable
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the Number between 6 to 9");
		int num=int.Parse(Console.ReadLine());
		if(num>=6&&num<=9)
		{
			for(int i=1;i<=10;i++)
			{
				Console.WriteLine(num+" * "+i+" = "+(num*i));
			}
		}
	}
}