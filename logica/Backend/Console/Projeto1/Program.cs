using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 2: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero + numero2;
            Console.WriteLine("O resultado é: " + soma);
        }
    }
}
