using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto");
            string produto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade comprada");
            int qtdAdquirida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço unitário");
            float preco = float.Parse(Console.ReadLine()); 
            double resultadoFuncao;

           resultadoFuncao = Produto(produto, qtdAdquirida, preco);

            float Produto (string produto, int qtd, float preco){
                    float desconto;
                    float valorBruto = qtdAdquirida * preco;

                    if(qtdAdquirida <= 5){
                         desconto = 0.02f;

                    }else if(qtdAdquirida > 5 && qtdAdquirida <= 10){
                        desconto = 0.03f;

                    }else{
                        desconto = 0.05f;
                    }
                        float total = valorBruto * desconto;
                        float totalPagar =  valorBruto - total;
                        
                        Console.WriteLine("Total: " + valorBruto);
                        Console.WriteLine("Total da compra com desconto: " + totalPagar);
                        return totalPagar;

            }
        }
    }
}
