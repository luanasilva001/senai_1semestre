using System;

namespace Classes_Estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2,5));

            Console.WriteLine("Digite um valor");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine(Conversor.ConverterDolarParaReal());

            Console.WriteLine(Conversor.ConverterRealParaDolar());

            Testar();
        }

        static void Testar(){

        }
    }
}
