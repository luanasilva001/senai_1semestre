using System;
using Encapsulamento.Classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.NomeTitular = "Luana gata";
            m.Bandeira = "MasterCard";
            m.Numero = "123456";
            m.CVV = "461";

            Console.WriteLine($"O titular: {m.NomeTitular}");
            Console.WriteLine($"Possuí o token: {m.Token}");
            Console.WriteLine($"Possuí a bandeira: {m.Bandeira}");
            Console.WriteLine($"Número: {m.Numero}");
            Console.WriteLine($"CVV: {m.CVV}");
            Console.WriteLine($"Limite: {m.Limite}");
        }
    }
}
