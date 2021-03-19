using System;
using MVC_Console.Controllers;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            // prod.Cadastrar();
            prod.ListarProdutos();


            Console.WriteLine($"Deseja cadastrar algum cliente?");
            string resposta = Console.ReadLine();
            
            if(resposta == "Sim")
            {
                ClienteController clientes = new ClienteController();
                // clientes.CadastrarClientes();
                clientes.ListarCliente();
            }
        }
    }
}
