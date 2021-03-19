using System;

namespace Transito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cor do semaforo");
            string cor = (Console.ReadLine());

            if(cor == "Vermelho"){
                Console.WriteLine("Pare o carro!");
            }else if(cor == "Amarelo"){
                Console.WriteLine("Diminua a velocidade e pare o carro!");
            }else{
                Console.WriteLine("Continue acelerando");
            }
        }
    }
}
