using System;
class DateOfWeek
{
	public static void Main(string[] args)
	{
		int day=int.Parse(args[0]);
		int month=int.Parse(args[1]);
		int year=int.Parse(args[2]);
		
		int y0=(year-(14-month))/12;
		int x=(y0+y0/4)-(y0/100+y0/400);
		int m0=(month+12)*((14-month)/12)-2;
		int d0=((day+x+31*m0)/12)%7;
		Console.WriteLine(d0);
	}
}