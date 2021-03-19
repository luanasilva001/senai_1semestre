using System;

namespace Encapsulamento.Classes
{
    public class MasterCard : Cartao
    {
        private int parcelas;

        public void ExibirLimite(){
            System.Console.WriteLine(this.limite);
        }
    }
}