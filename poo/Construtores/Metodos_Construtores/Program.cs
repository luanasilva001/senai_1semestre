using System;
using Metodos_Construtores.Classes;

namespace Metodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            
            Pessoa pessoa = new Pessoa(nome, sobrenome);
        }
    }
}
