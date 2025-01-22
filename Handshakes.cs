using System;
class Qunantity
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the no of student");
		int no_of_handshake=Convert.ToInt32(Console.ReadLine());
		
		int maxHandShake= (no_of_handshake * (no_of_handshake - 1)) / 2;
		Console.WriteLine("The number of possible handshake is "+maxHandShake);
	}
	
	
}