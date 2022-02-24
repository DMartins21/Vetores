using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Quntos quartos estao vagos?");
            int n = int.Parse(Console.ReadLine());

            Registro[] vect = new Registro[n];

            Console.WriteLine("Quantos quartos serao alugados?");
            int e = int.Parse(Console.ReadLine());
            for (int i = 1; i <= e; i++)
            {
                Console.WriteLine("Aluguel:" + i);
                Console.WriteLine("Escreva seu nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Escreva seu email:");
                string email = Console.ReadLine();
                Console.WriteLine("Em qual quarto ficara:");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Registro { Email = email, Nome = nome };
            }
            Console.WriteLine("Quartos Ocupados");
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }
        }
    }
}
