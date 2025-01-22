using System;
class Discount_Amount
{
	public static void Main(string[] args)
	{
		int student_Fee=125000;
		int discounPercent=10;
		int discountPrice=(student_Fee*discounPercent)/100;
		int discountAmount=student_Fee-discountPrice;
		Console.WriteLine("The discount amount in INR "+discountAmount+" and final discounted fee in INR "+discountPrice);
	}
}

		