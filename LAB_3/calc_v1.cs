using System;
using System.Reflection;
[assembly : AssemblyVersion("1.0.0.0")]
namespace calculator
{
	public class calc
	{
		public static int addition(int n1,int n2)
		{
			Console.WriteLine("addition of calc v1.0.0.0");
			return n1+n2;
		}
		public static int multiplication(int n1,int n2)
		{
			Console.WriteLine("multiplication of new calc v1.0.0.0");
			return n1*n2;
		}
	}
}