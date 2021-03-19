using System;

namespace Abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        public DateTime Data{get;set;}
        protected float valor;
        public float Valor {get;set;}
        public string Cancelar(){
            return "";
        }
         public abstract string Desconto(float valor);
         public abstract string Juros (double parcelas);

    }
}