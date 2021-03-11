using System;
//using Shared;

namespace CoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oi, está pronto para a diversão? (S/N)");

            var resultado = Console.ReadLine();

            if(resultado == "S")
            {
                Console.WriteLine("Qual a sua data de nascimento? (dd/MM/yyyy)");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                //var idade = Pessoa.CalcularIdade(dataNascimento);

                Console.WriteLine($"Sua idade é: {idade}");
            }
            else{
                Console.WriteLine("Que pena =/");
            }
        }
    }
}
