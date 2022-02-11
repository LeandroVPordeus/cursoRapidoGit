using System;

namespace Hotelzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospede[] vet = new Hospede[10];
            Console.WriteLine("Bem VIndo ao Grande Hotel !!!!!!");
            Console.Write("Quantos Quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Quarto:");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Hospede(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quarto Ocupado: ");

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }

            Console.WriteLine("Tenha um bom dia");

            Console.ReadLine();
        }
    }
}
