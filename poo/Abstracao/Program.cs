using System;
using Abstracao.Classes;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            Credito credito = new Credito();
            Debito debito = new Debito();
            int escolha;
            string menu;

            Console.WriteLine("Qual o valor da fatura?");
            float valor = float.Parse(Console.ReadLine());
            
            do{

             Console.WriteLine("Como você deseja pagar?");
             Console.WriteLine("Selecione uma opção abaixo");
             Console.WriteLine("[1] - Boleto");
             Console.WriteLine("[2] - Cartão de crédito");
             Console.WriteLine("[3] - Cartão de débito");
             Console.WriteLine("[4] - Exibir dados do cartão");
             Console.WriteLine("[5] - Sair");
             escolha = int.Parse(Console.ReadLine());
             


            switch(escolha){
                case 1:
                    Console.WriteLine("Boleto!");
                    Console.WriteLine(boleto.Desconto(valor));
                    boleto.Pagar(valor);
                    Console.WriteLine($"Horário: {boleto.Data = DateTime.Now}");
                    Console.WriteLine($"Código de barras: {boleto.CodigoDeBarras}");
                    Console.WriteLine("Deseja voltar para o menu? [s/n]");
                    menu = Console.ReadLine();
                    Console.Clear();
                break;

                case 2:
                    Console.WriteLine("Cartão de crédito!");
                    Console.WriteLine("Digite a bandeira do cartão");
                    credito.bandeira = Console.ReadLine();
                    Console.WriteLine("Digite o número");
                    credito.numero = Console.ReadLine();
                    Console.WriteLine("Digite o nome do titular do cartão");
                    credito.titular = Console.ReadLine();
                    Console.WriteLine("Digite o CVV do cartão");
                    credito.cvv = Console.ReadLine();
                    Console.Clear();
                    credito.SalvarCartao();
                    Console.WriteLine("Em quantas parcelas você quer pagar?");
                    float parcelas = int.Parse(Console.ReadLine());
                    Console.WriteLine(credito.Juro(parcelas));
                    Console.WriteLine($"Horário: {credito.Data = DateTime.Now}");
                    Console.WriteLine("Deseja voltar para o menu? [s/n]");
                    menu = Console.ReadLine();
                break;

                case 3:
                    Console.WriteLine("Cartão de débito!");
                    Console.WriteLine("Digite a bandeira do cartão");
                    debito.bandeira = Console.ReadLine();
                    Console.WriteLine("Digite o número");
                    debito.numero = Console.ReadLine();
                    Console.WriteLine("Digite o nome do titular do cartão");
                    debito.titular = Console.ReadLine();
                    Console.WriteLine("Digite o CVV do cartão");
                    debito.cvv = Console.ReadLine();
                    debito.SalvarCartao();
                    Console.WriteLine($"Limite: {debito.Limite}");
                    debito.Pagar(valor);
                    Console.WriteLine($"Horário: {debito.Data = DateTime.Now}");
                    Console.WriteLine("Deseja voltar para o menu? [s/n]");
                    menu = Console.ReadLine();
                break;

                case 4:
                    Console.WriteLine("Deseja ver as informações de qual cartão?\n[1]Crédito\n[2]Débito");
                    int cartao = int.Parse(Console.ReadLine());

                    switch(cartao){
                        case 1:
                            credito.SalvarCartao();
                            Console.WriteLine($"Limite: {debito.Limite}");
                            Console.WriteLine("Deseja retornar para o menu? [s]/[n]");
                            menu = Console.ReadLine();
                        break;

                        case 2:
                            debito.SalvarCartao();
                            Console.WriteLine($"Limite: {debito.Limite}");
                            Console.WriteLine("Deseja retornar para o menu? [s]/[n]");
                            menu = Console.ReadLine();
                        break;

                        default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Deseja retornar para o menu? [s]/[n]");
                        menu = Console.ReadLine();
                        break;
                    }
                break;

                case 5:
                    Console.WriteLine("Volte sempre! Para confirmar sua saída do programa, digite N.");
                    menu = Console.ReadLine();
                break;

                    default:
                        Console.WriteLine("Opcao inválida, deseja voltar para o menu? s/n");
                        menu = Console.ReadLine();
                        break;
                    }
               }while (menu.ToLower() == "s");
            }
        }
    }
