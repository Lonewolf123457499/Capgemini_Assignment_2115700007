using System;
class First_Is_Smallest
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the first Number");
		int num1=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the second Number");
		int num2=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the third Number");
		int num3=int.Parse(Console.ReadLine());
		bool result=false;
		if(num2>num1&&num3>num1)
		{
			result=true;
		}
		else{
			result =false;
		}
		Console.WriteLine("Is the first number the smallest? "+result);
	}
}
			