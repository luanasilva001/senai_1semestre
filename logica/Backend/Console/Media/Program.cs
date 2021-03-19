using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            string situacao = "";

            Console.WriteLine("Sua média é de: " + media);

            if(media > 7) {
                situacao = "Aprovado!";
            } else{
                situacao = "Reprovado!";
            }

            Console.WriteLine(situacao);
        }
    }
}
