using System;
class Odd_Even
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the  Natural Number");
		int num=int.Parse(Console.ReadLine());
		if(num>0)
		{
			for(int i=1;i<=num;i++)
			{
				if(i%2==0)
				{
					Console.WriteLine("The Number is Even "+ i);
				}
				else
				{
					Console.WriteLine("The Number is Odd "+ i);
				}
			}
		}
	}
}
		
			