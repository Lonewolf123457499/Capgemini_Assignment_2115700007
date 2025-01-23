using System;
class HarshadNumber
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the Number");
		int num=int.Parse(Console.ReadLine());
		int sum=0;
		int numCopy=num;
		while(num!=0)
		{
			int d=num%10;
			sum+=d;
			num=num/10;
		}
		
		if(numCopy%sum==0)
		{
			Console.WriteLine("The number is Harshad Number "+numCopy);		
		}
		else
		{
			Console.WriteLine("The number is not Harshad Number is "+numCopy);
		}
		
		
		
	}
}
	
