using System;

namespace Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
           int idade;
           string nome;
           double salario;
           string civil; 
           do
           {
               Console.WriteLine("Digite qual é o seu nome");
               nome = Console.ReadLine();

               if(nome == ""){
                   Console.WriteLine("Erro! Está em branco.");
               }
           } while (nome == "");

           do
           {
               Console.WriteLine("Agora digite qual é a sua idade");
               idade = int.Parse(Console.ReadLine());

               if(idade < 0 || idade > 150){
                   Console.WriteLine("Erro! Digite uma idade valida");
               }
           } while (idade < 0 || idade > 150);

           do
           {
               Console.WriteLine("Agora digite qual é o seu salário");
               salario = double.Parse(Console.ReadLine());

               if(salario == 0 ){
                   Console.WriteLine("Erro! Digite um salário maior que 0!");
               }
           } while (salario == 0);

            do{
                
            Console.WriteLine("Qual é o seu estado civil?");
            Console.WriteLine("(a) Solteiro(a)");
            Console.WriteLine("(b) Casado(a)") ;
            Console.WriteLine("(c) Viuvo(a)") ;
            Console.WriteLine("(d) Divorciado(a)");
            civil = Console.ReadLine();

             if(civil == "a" && civil == "b" && civil == "c" && civil == "d"){
                 Console.WriteLine("Erro!");
                   break;
             }
             }while(civil != "a" && civil != "b" && civil != "c" && civil != "d");

                Console.WriteLine("Nome: " + nome );
                Console.WriteLine("Idade: " +idade + " anos");
                Console.WriteLine("Salário: " + salario + " reais");
                Console.WriteLine("Estado civil: " + civil);
    }

    }
}
