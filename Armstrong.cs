using System;
class Armstrong
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the Number");
		int num=int.Parse(Console.ReadLine());
		int numCopy=num;
		int sum=0;
		while(num!=0)
		{
			int d=num%10;
			sum=sum+d*d*d;
			num=num/10;
		}
		
		if(numCopy==sum)
		{
			Console.WriteLine("Number is Armstrong");
		}
		else
		{
			Console.WriteLine("Number is not Armstrong");
		}
	}
}
		
			