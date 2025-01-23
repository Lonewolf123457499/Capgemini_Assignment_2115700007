using System;
class CountDigit
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the Number");
		int num=int.Parse(Console.ReadLine());
		int count=0;
	
		while(num!=0)
		{
			int d=num%10;
			count++;
			num=num/10;
		}
		Console.WriteLine("The number of digit in number is "+count);
		
		
	}
}
		
			