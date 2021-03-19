using System;

namespace Usuario
{
    class Program
    {
        static void Main(string[] args)
        {

            string usuario;
            string senha;
            do{
                Console.WriteLine("Digite seu login de usúario");
                usuario = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();

                if(usuario == senha){
                    Console.WriteLine("Erro");
                }

            }while(usuario == senha );
                 Console.WriteLine("Certinho! Parabéns.");
        }
    }
}
