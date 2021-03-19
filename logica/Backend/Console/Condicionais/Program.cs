using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Bem-vindo a seletiva de Counter Strike!");
            Console.WriteLine("---------------------------------------");  
            Console.WriteLine("Você gostaria de participar? Sim ou Não");
            string resposta = Console.ReadLine();

            if(resposta == "Sim"){
                Console.WriteLine("Agora vamos analisar o seu currículo.");
                Console.WriteLine("Insira sua média escolar");
                int media = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de faltas");
                int faltas = int.Parse(Console.ReadLine());
                if(media >= 50 && faltas <= 10){
                    Console.WriteLine("Parabéns, seja bem vindo!");
                }else{
                    Console.WriteLine("Que pena, você precisa melhorar suas notas e faltas");
                }
            }else{
                Console.WriteLine("Beleza, fica para a próxima!"); 
            }

        }
    }
}
