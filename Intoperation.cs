using System;

class IntOperation
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Enter the value of a ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of b ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of c  ");
        int c = Convert.ToInt32(Console.ReadLine());
		
        int result1 = a + b * c;     
        int result2 = a * b + c;     
        int result3 = c + a / b;      
        int result4 = a % b + c;     

        Console.WriteLine("The results of Int Operations are "+result1+","+result2+","+result3+","+result4);
      
    }
}
