using System;

namespace Abstracao.Classes
{
    public class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;
        private double parcelas;
        

        public override string Desconto(float valor)
        {
            return "";
        }

        public override string Juros(double parcelas)
        {
            return "";
        }

        public void SalvarCartao(){
             Console.WriteLine($"Bandeira: {bandeira}\nNúmero: {numero}\nTitular: {titular}\nCVV: {cvv}");
         }
    }
}