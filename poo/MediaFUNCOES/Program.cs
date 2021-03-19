using System;

namespace ExFUNCAO
{
    class Program
    {
        static void Main(string[] args)
        {

                Media ();
                void Media () {

                string[] nomes = new string [4];
                float[] nota1 = new float [10];
                float[] nota2 = new float [10];
                float[] nota3 = new float [10];
                float[] nota4 = new float [10];
                float[] media = new float [10];

                for (var i = 0; i < 4; i++)
                {
                    Console.WriteLine("Digite o nome do aluno");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine("Digite a primeira nota do aluno");
                    nota1[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a segunda nota do aluno");
                    nota2[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a terceira nota do aluno");
                    nota3[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a quarta nota do aluno");
                    nota4[i] = float.Parse(Console.ReadLine());

                    media[i] = (nota1[i] + nota2[i] + nota3[i] + nota4[i])/4;

                }
                    for (var i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"");
                    }
                
                    for (var i = 0; i < 10; i++)
                    {
                         if(media [i] >= 7){
                               Console.WriteLine($"O(A) aluno(a) de media = {media[i]} está aprovado!");
                            
                        }else{
                               Console.WriteLine($"O(A) aluno(a) de média = {media[i]} e está reprovado"); 
                            
                        }
                    }
                 }        
              }
          }
     }
}

