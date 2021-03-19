using System;

namespace Aumento
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu salário");
            int salario = int.Parse(Console.ReadLine());
            

            if(salario <= 500 ){
                double reajuste = 30 * salario/100;
                Console.WriteLine("Você irá receber um reajuste de 30% no seu salário, que vai ficar um total de " + reajuste + " reais");
            }else{
                Console.WriteLine("Você não tem direito ao aumento.");
            }

        }
    }
}
