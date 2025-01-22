using System;
class Profit_Or_Loss
{
	public static void Main(string[] args)
	{
		int costPrice=129;
		int sellingPrice=191;
		int profit=sellingPrice-costPrice;
		double profit_Percentage=(profit*100)/costPrice;
		Console.WriteLine("The Cost Price in INR "+costPrice+" and Selling Price in INR "+sellingPrice);
		Console.WriteLine("The profit in INR "+profit+ " and the Profit Percentage in INR "+profit_Percentage);
	}
}

		