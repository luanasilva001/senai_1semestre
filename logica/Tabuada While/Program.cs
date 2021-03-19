using System;

namespace Tabuada_While
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Você deseja saber a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());
            
            for (int tabuada = 0; tabuada <= 10; tabuada++)
            {
                Console.WriteLine($"{resposta} * {tabuada} = {resposta * tabuada}");
            }
        }
    }
}
