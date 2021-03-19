using System;
using AulaPOO.Classes;

namespace AulaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            string escolha; 
                do
                {
                    Console.WriteLine("O Celular está ligado? S/N");
                    escolha = Console.ReadLine();

                    if(escolha.ToLower() == "s" ){
                    celular1.ligado = true;

                    Console.WriteLine("Digite a cor do celular: ");
                    celular1.cor = Console.ReadLine();

                    Console.WriteLine("Digite o modelo do celular: ");
                    celular1.modelo = Console.ReadLine();

                    Console.WriteLine("Digite o tamanho do celular: ");
                    celular1.tamanho = Console.ReadLine();

                    // MENSAGEMMMMMMMMMMMM
                    Console.Write("Deseja enviar alguma mensagem? S/N ");
                    string resposta = Console.ReadLine();
                    
                    if(resposta.ToLower() == "s"){
                       celular1.mensagens = true;
                        celular1.Mensagem(celular1.mensagens);
                    }else{
                          celular1.mensagens = false;
                          celular1.Mensagem(celular1.mensagens);
                    }
                    // FIM MENSAGEM

                    // LIGACAO
                    Console.Write("Deseja fazer alguma ligação? S/N ");
                    string resposta2 = Console.ReadLine();
                     if(resposta2.ToLower() == "s"){
                        celular1.ligacoes = true;
                        celular1.FazerLigacao(celular1.ligacoes);
                    }else{
                          celular1.ligacoes = false;
                          celular1.FazerLigacao(celular1.ligacoes);
                    }

                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-----INFORMAÇÕES SOBRE O CELULAR-----");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("COR: " + celular1.cor);
                    Console.WriteLine("MODELO: " + celular1.modelo);
                    Console.WriteLine("TAMANHO: " + celular1.tamanho);
                    break;

                    
                    }else {

                    Console.WriteLine("Fim");
                    }

                    }while (escolha.ToLower() == "s");
            }
        }
    }

                    //     Console.WriteLine("Fim");
                    //     celular1.desligado = false;
                    // }