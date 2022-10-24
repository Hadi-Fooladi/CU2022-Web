using System;
using System.Collections.Generic;

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

			//DisplayFields(typeof(Person));

			int[] numbers;
			List<int> list = new List<int>();

			numbers = new int[100];

			for (int i = 0; i < 100; i++)
			{
				list.Add(i * 2);
				numbers[i] = i;
			}

			foreach (var number in list)
				Console.WriteLine(number);
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
