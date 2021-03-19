using System;

namespace Nota0a10
{
    class Program
    {
        static void Main(string[] args)
        {

            int resposta;

            do{
            Console.WriteLine("Digite uma nota entre 0 e 10");
            resposta = int.Parse(Console.ReadLine());

            if (resposta < 0 || resposta > 10){
                Console.WriteLine("Número inválido");
            }

            }while(resposta < 0 || resposta > 10);
            Console.WriteLine("Número aceito"); 
        }
    }
}
