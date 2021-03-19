using System;

namespace Nadador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a liga de nadadores. Para começar, qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if( idade  >=  5  &&  idade <= 7 ){
                Console.WriteLine("Sua categoria é a Infantil A");
                
            }else if ( idade  >=  8  &&  idade <= 10 ){
                Console.WriteLine("Sua categoria é a Infantil B");

            }else if ( idade  >=  11  &&  idade <= 13 ){
                Console.WriteLine("Sua categoria é a Juvenil A");

            }else if ( idade  >=  14  &&  idade <= 17 ){
                Console.WriteLine("Sua categoria é a Juvenil B");
            }else{
                Console.WriteLine("Sua categoria é a Sênior");
            }
        }
    }
}
