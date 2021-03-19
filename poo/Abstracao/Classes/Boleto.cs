using System;

namespace Abstracao.Classes
{
    public class Boleto : Pagamento
    {
        private int codigoDeBarras;
          
        public int CodigoDeBarras{
            get{return codigoDeBarras;} 
            set {codigoDeBarras = value;}
        }

        public void Registrar(){
            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next();
        }

        public override string Desconto(float valor)
        {  
            this.valor = valor;
            this.valor = this.valor - (this.valor * 0.12f);
            return $"Você terá um desconto de 12%, preço atual de {this.valor} reais!";
        }
        public override string Juros(double parcelas)
        {
            return "";
        }

        public void Pagar(float valor)
        {
            Console.WriteLine("Pago!");
        }
    }
}