using System;

namespace MDHM
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses = idade * 12; 
            int dias = 365;
            int horas = 24;
            int minutos = 60;

            Console.WriteLine("Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            int contai = idade * meses;
            Console.WriteLine("Sua idade convertida em meses da um total de: " + contai);

            int contad = idade * dias;
            Console.WriteLine("Sua idade convertida em dias da um total de: " + contad);

            int contah = idade * horas;
            Console.WriteLine("Sua idade convertida em horas da um total de: " + contah);

            int contam = idade * minutos;
            Console.WriteLine("Sua idade convertida em minutos da um total de: " + contam);

        }
    }
}
