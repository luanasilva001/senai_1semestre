using System;

namespace Abstracao.Classes
{
    public class Debito : Cartao
    {
        private float limite = 600;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }
        public float Pagar(float valor) => this.valor - limite;
    }
}