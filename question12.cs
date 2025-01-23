using System;
class WhileSum
{
	
	public static void Main(string [] agrs)
	{
		Console.WriteLine("Enter the natural number");
		int num=Convert.ToInt32(Console.ReadLine());
		int sum_while=0;
		int sum_formula=0;
		int no=num;
		if(num>0)
		{
			while(num>0)
			{
				sum_while+=num;
				num--;
			}
			sum_formula=(no*(no+1))/2;
		}
		Console.WriteLine("Sum from formula is "+sum_formula);
		Console.WriteLine("Sum from formula is "+sum_while);
				
	}
}

			
			