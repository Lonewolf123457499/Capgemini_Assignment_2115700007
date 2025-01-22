using System;
class Track
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the sides of triangle in meter");
		int s1=int.Parse(Console.ReadLine());
		int s2=int.Parse(Console.ReadLine());
		int s3=int.Parse(Console.ReadLine());
		int perimeter=s1+s2+s3;
		int no_round=5000/perimeter;
		Console.WriteLine("The total number of rounds the athlete will run is "+no_round+" to complete 5 km");
	}
}
