using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorial
{
	internal class Person
	{
		public Person()
		{
			Counter++;
		}

		public Person(string firstName, string lastName) : this()
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public static int Counter { get; private set; }

		public string FirstName;
		public string LastName;

		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

	}
}
