using System;
using System.Collections.Generic;
using Lista_Objetos.Classes;

namespace Lista_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Produto> produtos = new List<Produto>();
          Produto[] arrayProduto = {};

          produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
          produtos.Add(new Produto(2, "Xiaomi Watch", 1844.56f));
          produtos.Add(new Produto(3, "Zenfone Asus", 4994.44f));
          produtos.Add(new Produto(4, "Samsung", 3393.33f));
          produtos.Add(new Produto(5, "Motorola G8", 4444.54f));

          Produto produto = new Produto();
          produto.Codigo = 67;
          produto.Nome = "IPhone XII";
          produto.Preco = 5674.55f;

          produtos.Add(produto);

          foreach(Produto elemento in produtos)
          {
            Console.WriteLine("Código: " + elemento.Codigo);
            Console.WriteLine("Nome: " + elemento.Nome);
            Console.WriteLine("R$: " + elemento.Preco);
          }

          produtos.RemoveAt(3);

          Console.WriteLine("\nRemoção Feita: \n");

          foreach(Produto elemento in produtos)
          {
            Console.WriteLine("Código: " + elemento.Codigo);
            Console.WriteLine("Nome: " + elemento.Nome);
            Console.WriteLine("R$: " + elemento.Preco);
          }

          produtos.RemoveAll(x => x.Codigo == 5);
          Console.WriteLine("Lista alterada\n");

          foreach(Produto elemento in produtos)
          {
            Console.WriteLine("Código: " + elemento.Codigo);
            Console.WriteLine("Nome: " + elemento.Nome);
            Console.WriteLine("R$: " + elemento.Preco);
          }
        }
    }
}
