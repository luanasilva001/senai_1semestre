using System;
using System.Threading;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmr1 = 0, nmr2 = 1, aux;

            for (int  fibonacci  =  0 ; fibonacci  <=  13 ; fibonacci ++ )
            {
              
                aux = nmr1;
                nmr1 = nmr2;
                nmr2 = nmr1 + aux;
                Console.WriteLine("{0}", nmr2);
                // Thread.Sleep(200);
            }
            Console.ReadLine();
        }
    }
}
