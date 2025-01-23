using System;
class LargestAmongThreeNumber
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the first Number");
		int a=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the second Number");
		int b=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the third Number");
		int c=int.Parse(Console.ReadLine());
		bool result1=false;
		bool result2=false;
		bool result3=false;
		if(a>b&&a>c)
		{
			result1=true;
		}
		else if(b>a&&b>c)
		{
			result2=true;
		}
		else if(c>a&&c>b)
		{
			result3=true;
		}
		Console.WriteLine("Is the first number the largest? "+result1);
		Console.WriteLine("Is the second number the largest? "+result2);
		Console.WriteLine("Is the third number the largest? "+result3);
	}
}
		
			