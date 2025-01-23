using System;
class Sum_Until_Zero
{
	public static void Main(string [] agrs)
	{
		double total =0.0;
		double userValue;
		while(true)
		{
			Console.WriteLine("Enter the user value");
			userValue=Convert.ToDouble(Console.ReadLine());
			if(userValue==0.0||userValue<0)
			{
				break;
			}
			total=total+userValue;
		}
		Console.WriteLine("Total sum is "+ total);
	}
}
			