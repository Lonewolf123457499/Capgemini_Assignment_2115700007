using System ;
class Power_calculation
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the base");
		int _base=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter exponent");
		int exponent =Convert.ToInt32(Console.ReadLine());
		
		int ans=(int)Math.Pow(_base,exponent);
		
		Console.WriteLine(_base+" to the power "+exponent+" is "+ans);
	}
}
		
