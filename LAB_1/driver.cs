using System;
using addition;
namespace driver_prog
{
	public class driver
	{
		static void Main(string[] args)
		{
			int n1,n2;
			
			Console.Write("Enter first number : ");
			n1=Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter second number : ");
			n2=Convert.ToInt32(Console.ReadLine());
			
			
			Console.WriteLine(addition_class.Add(n1,n2));
			
			Console.ReadLine();
		}
	}
}
