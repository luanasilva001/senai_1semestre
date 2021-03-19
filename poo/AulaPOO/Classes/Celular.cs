using System;

namespace AulaPOO.Classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        public bool desligado;
        public bool mensagens;
        public bool ligacoes;

        //  string resposta;


       
        public void Ligar(bool ligado){
            if(ligado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("O celular está desligado!");
            }
        }

        public void Desligar(bool desligado){
             if(desligado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("O celular está desligado!");
            }
        }

         public void Mensagem(bool mensagem){
             if(mensagem == true){
                Console.WriteLine("Escreva a mensagem: ");
                string mensagens = Console.ReadLine();

                Console.WriteLine("Sua mensagem foi enviada!");
             }else{
                 Console.WriteLine("Outro dia você manda!");
             }
        }

        public void FazerLigacao(bool ligacao){
            if(ligacao == true){
            Console.WriteLine("Para quem?");
            string quem = Console.ReadLine();
            Console.WriteLine("Ligando! Tu...Tu....");
            Console.WriteLine($"A(O) {quem} não atendeu! Ligue outra hora.");

            }else{
                Console.WriteLine("Outro dia vc liga!");
            }
        }
    }
}
