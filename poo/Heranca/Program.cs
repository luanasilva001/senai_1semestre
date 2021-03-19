using System;
using Heranca.Classes;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.cpf = "000.000.000-00";

            pf.nome = "Luana gata";

            Console.WriteLine (pf.DarBoasVindas(pf.nome));
            Console.WriteLine(pf.ValidarCPF(pf.cpf));
        }
    }
}
