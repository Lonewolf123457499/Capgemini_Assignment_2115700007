using System;
class Calcualtor
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter the  two number");
		double num1=Convert.ToDouble(Console.ReadLine());
		double num2=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the vaild operation");
		string op=Console.ReadLine();
		
		switch(op)
		{
			case "+":
			Console.WriteLine("Sum of two number is "+(num1+num2));
			break;
			case "-":
			Console.WriteLine("Subtraction of two number is "+(num1-num2));
			break;
			case "*":
			Console.WriteLine("Multiplication of two number is "+(num1*num2));
			break;
			
			case "/":
			Console.WriteLine("Divison  of two number is "+(num1/num2));
			break;
			
			
			default:
			Console.WriteLine("Invaild operation");
			break;
		}
	}
}