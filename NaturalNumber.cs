using System;
class NaturalNumber
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the Natural Number to find sum upto n number");
		
			int num=int.Parse(Console.ReadLine());
			int result=0;
			if(num>0)
			{
				result=(num*(num+1))/2;
				Console.WriteLine("The sum of "+num+" natural numbers is "+result);				
			}
			else
			{
				Console.WriteLine("The number "+num+" is  not a natural number");
			}
		
	}
}
				
				
		