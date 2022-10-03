using System;

namespace CSharp_Tutorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var jeff = new Person();
			jeff.FirstName = "Jeff";
			jeff.LastName = "Bezos";
			Console.WriteLine(jeff.FullName);
		}
	}
}
