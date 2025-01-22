using System;
class No_of_pen
{
	public static void Main(string[] args)
	{
		int no_of_pen=14;
		int no_of_student=3;
		int non_distributed_pen=no_of_pen%no_of_student;
		int pen_Per_Student=no_of_pen/no_of_student;
		Console.WriteLine("The Pen per Student is "+pen_Per_Student+" and the remaining pen not distributed is "+non_distributed_pen);
	}
}
