using System;
class Discount_Amount_Q9
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the student fee");
		int student_Fee=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the discount Percent");
		int discounPercent=Convert.ToInt32(Console.ReadLine());
		
		
		int discountPrice=(student_Fee*discounPercent)/100;
		int discountAmount=student_Fee-discountPrice;
		Console.WriteLine("The discount amount in INR "+discountAmount+" and final discounted fee in INR "+discountPrice);
	}
}

		