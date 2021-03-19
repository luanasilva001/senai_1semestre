using System;

namespace Calculadora_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação você deseja realizar? /nSoma, Subtração, Divisão ou Multiplicação?");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            float num2 = float.Parse(Console.ReadLine());

           float resultado = 0f;

            switch(operacao){
                case "Soma":
                     resultado = num1 + num2;
                break;

                case "Subtração":
                    resultado = num1 - num2;
                break;

                case "Divisão":
                    resultado = num1 / num2;
                break;

                case "Multiplicação":
                    resultado = num1 * num2;
                break;

                default:
                    operacao = "Invalida";
                    Console.WriteLine("Operação inválida!");
                break;
            }

            Console.WriteLine($"Calculo: {num1} com {num2} = {resultado}");
        }
    }
}
