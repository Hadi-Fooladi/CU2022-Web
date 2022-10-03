using System;

namespace CSharp_Tutorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//var jeff = new Person();
			//jeff.FirstName = "Jeff";
			//jeff.LastName = "Bezos";
			//Console.WriteLine(jeff.FullName);
			//Console.WriteLine(Person.Counter);

			//var p = new Person("Hadi", "Fooladi");
			//Console.WriteLine(p.FullName);
			//Console.WriteLine(Person.Counter);

			//var v1 = new Value { Number = 1 };
			//Console.WriteLine(v1.Number);

			//foo(v1);
			//Console.WriteLine(v1.Number); // 1 or 56

			DisplayFields(typeof(Person));
		}

		public static void foo(Value value)
		{
			value.Number = 56;
		}

		public static void DisplayFields(Type type)
		{
			var fields = type.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

			foreach(var field in fields)
			{
				Console.WriteLine(field.Name);
			}
		}
	}
}
