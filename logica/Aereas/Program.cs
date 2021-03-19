using System;

namespace Aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema passagens aéreas!");
            
            bool senhaValida;
            int escolha;
            int contador = 0;
            string opcao;
            string[] nome = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            string[] data = new string[5];
            string[] horario = new string [5];

            do
            {
            
             Console.WriteLine("Digite a senha para entrar no sistema");
             string senha = Console.ReadLine();
             senhaValida  =  Sistema (senha);
               
            } while (!senhaValida);

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("[1] - Cadastrar passageiro");
                Console.WriteLine("[2] - Listar passageiro");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastrar passageiro");
                        do
                        {

                        if(contador < 5){

                        Console.WriteLine("Digite o nome do passageiro");
                        nome[contador] = Console.ReadLine(); 

                        Console.WriteLine("Digite a origem");
                        origem[contador] = Console.ReadLine();

                        Console.WriteLine("Digite o destino do voo");
                        destino [contador] = Console.ReadLine();

                        Console.WriteLine("Digite a data do voo");
                        data[contador] = Console.ReadLine();

                        Console.WriteLine("Digite o horário");
                        horario[contador] = Console.ReadLine();

                        contador++; 
                        }else{
                            Console.WriteLine("Limite excedido");
                            break;
                        }
                        Console.WriteLine("Deseja cadastrar outro passageiro? S/N");
                        opcao = Console.ReadLine();
                        }while (opcao.ToUpper() == "S");
                        break;

                    case 2:
                        Console.WriteLine("Listar Passageiros");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiro: {nome[i]}");
                            Console.WriteLine($"Origem: {origem[i]}");
                            Console.WriteLine($"Destino: {destino[i]}");
                            Console.WriteLine($"Data: {data[i]}");
                            Console.WriteLine($"Horário: {horario[i]}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Até a próxima");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                

            } while (escolha != 0);

            bool Sistema(string senhaValida){
                if(senhaValida == "123456"){
                    Console.WriteLine("Bem-Vindo!");
                    return true;
                }else{
                    Console.WriteLine("Tente novamente");
                    return false;
                }
            }
        }
    }
}
