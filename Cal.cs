using System;
class Calculator
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the first number");
		Double num1=Convert.ToDouble(Console.ReadLine());
		Double num2=Convert.ToDouble(Console.ReadLine());
		Double add=num1+num2;
		Double sub=num1-num2;
		Double mult=num1*num2;
		Double divide=num1/num2;
		
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+num1+" and"+num2+ " is"+add+" ,"+sub+" , "+mult+" and "+divide);
		
	}
}
