using System;
using System.Collections.Generic;

namespace POO_Produtos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario Usuario = new Usuario();

        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto");
            novoProduto.Preco = float.Parse(Console.ReadLine()); 

            DataCadastro = DateTime.Now;

            //Chamamos um métoddo do objeto/propriedade "Marca"
            novoProduto.Marca = Marca.Cadastrar();

            //Utilizamos o próprio método construtor para atribuir um objeto completo de usúario
            novoProduto.Usuario = new Usuario();

            ListaDeProdutos.Add(novoProduto);
        }

        public void Listar(){
            foreach (var item in ListaDeProdutos)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Código: " + item.Codigo);
                Console.WriteLine("Nome do produto: " + item.NomeProduto);
                Console.WriteLine("Preço do produto: " + item.Preco);
                Console.WriteLine("Data do cadastro: " + DataCadastro);
                Console.WriteLine("Marca: " + item.Marca.NomeMarca);
                Console.WriteLine("Cadastrado por: " + item.Usuario.Nome);
            }
            Console.ResetColor();
        }

        public void Deletrar(int cod){
                Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
                ListaDeProdutos.Remove(prodDelete);
        }
    }
}