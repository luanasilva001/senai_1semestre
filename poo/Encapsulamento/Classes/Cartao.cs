using System;

namespace Encapsulamento.Classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{get;set;}
        private string bandeira;
        public string Bandeira{get;set;}
        protected string token = "qwertyui";
        public string Token{
            get{return token;}
        }
        private string cvv;
        public string CVV{get;set;}
        protected float limite = 5000;
        public float Limite{get;set;}
        private string nomeTitular;
        public string NomeTitular{get;set;}

        public string RegistrarCompra(bool validado){
            return "";
        }

        public string ReceberNome(string nomeDigitado){
            return this.nomeTitular = nomeDigitado;
        }

        public void ExibirNome(){
            Console.WriteLine(this.nomeTitular);
        }
    }
}