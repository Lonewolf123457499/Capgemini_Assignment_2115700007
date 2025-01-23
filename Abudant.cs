using System;
class AbudantNumber
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the Number");
		int num=int.Parse(Console.ReadLine());
		int sum=0;
		for(int i=1;i<num;i++)
		{
			if(num%i==0)
			{
				
				sum=sum+i;
			}
		}
		
		if(sum>num)
		{
			Console.WriteLine("AbudantNumber ");
		}
		else
		{
			Console.WriteLine("Number is not AbudantNumber");
		}
	}
}