using System;
class Division_Quotient
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the first number");
		int num1=int.Parse(Console.ReadLine());
		int num2=int.Parse(Console.ReadLine());
		
		int quotient=num1/num2;
		int remainder=num1%num2;
		Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers " +num1 +" and "+num2);
	}
}
	