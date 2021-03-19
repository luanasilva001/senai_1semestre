using System;
using Objeto_Argumento.Classes;

namespace Objeto_Argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(1, "Read Dead Redemption", 499f);
            Produto produto2 = new Produto(2, "GTA 5", 56.5f);
            Produto produto3 = new Produto(3, "Detroit Become Human", 120.5f);
            Produto produto4 = new Produto(4, "Celeste", 3534.5f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);
            carrinho.AdicionarProduto(produto3);
            carrinho.AdicionarProduto(produto4);
            carrinho.MostrarProduto();

            Console.WriteLine("Após a alteração: ");
            Produto produto5 = new Produto(5, "GTA San Andreas", 130f);
            carrinho.AlterarItem(1, produto5);
            carrinho.MostrarProduto();
            

            Console.WriteLine("Deseja remover algum produto?");
            string resposta = Console.ReadLine();

            if(resposta == "s"){
                carrinho.RemoverProduto(produto1);
            }
                carrinho.MostrarProduto();
        }
    }
}
