using System;
class Distance_In_Yard_And_Miles
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the height in feet");
		int feet=Convert.ToInt32(Console.ReadLine());
		double yard=feet/3;
		double miles=yard/1760;
		
		Console.WriteLine("Distance in Yard "+yard+" and in Miles is "+miles);
	}
}