using System;
using SharedIngest;

namespace CoreTest
{
	class Program
	{
		static void Main(string[] args)
		{            
			DateTime birthDate = new DateTime(1988, 1, 25);

			var years = Person.CalculateAge(birthDate);

			Console.WriteLine($"Your age is: {years}");
		}
	}
}
