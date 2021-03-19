using System;

namespace Abstracao.Classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }

         private double parcelas;
         public string Juro(float parcelas)
        {
            this.parcelas = parcelas;

            if(parcelas <= 6){
               this.parcelas = this.parcelas * 1.05f;
               return $"Parcelas com juros de {this.parcelas}";

            }else if(parcelas >= 7 && parcelas <= 12){
                this.parcelas = this.parcelas * 1.08f;
                Console.WriteLine($"Limite: {limite}");
                return $"Parcelas com juros de {this.parcelas}";

             }else{
                 Console.WriteLine("Não é possível parcelas mais vezes");
             }
            return "";
         }
        public void Pagar(float valor)
        {
            Console.WriteLine("Pago!");
        }
    }
}