using System;
using Shared;

namespace CoreTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Oi, está pronto para a diversão? (S/N)");

			Console.WriteLine("Qual a sua data de nascimento? (dd/MM/yyyy)");
            
			DateTime dataNascimento = new DateTime(1988, 1, 25);

			var idade = Pessoa.CalcularIdade(dataNascimento);

			Console.WriteLine($"Sua idade é: {idade}");
		}
	}
}
