using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class ClienteView
    {
        public void ListarCliente(List<Cliente> clientes)
        {
            foreach (var item in clientes)
            {
                Console.WriteLine($"-------------INFORMAÇÕES SOBRE O CLIENTE CADASTRADO-------------");
                
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Email: {item.Email}");
                Console.WriteLine($"Telefone: {item.Telefone}");
                Console.WriteLine($"Endereço: {item.Endereco}");
                Console.WriteLine($"Data de nascimento: {item.DatadeNascimento}");
                Console.WriteLine($"Sexo: {item.Sexo}");
                Console.WriteLine($"CPF: {item.CPF}");
                Console.WriteLine("------------------------------------------------------------------");
                
                
            }
        }

        public Cliente CadastrarCliente()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine($"Digite o código do cliente");
            cliente.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do cliente");
            cliente.Nome = Console.ReadLine();
            
            Console.WriteLine($"Digite o email do cliente");
            cliente.Email = Console.ReadLine();
            
            Console.WriteLine($"Digite o telefone");
            cliente.Telefone = int.Parse(Console.ReadLine()
            );

            Console.WriteLine($"Digite o endereço");
            cliente.Endereco = Console.ReadLine();
            
            Console.WriteLine($"Digite a data de nascimento");
            cliente.DatadeNascimento = Console.ReadLine();
            
            Console.WriteLine($"Digite o sexo");
            cliente.Sexo = Console.ReadLine();
            
            Console.WriteLine($"Digite o CPF");
            cliente.CPF = int.Parse(Console.ReadLine()
            );
            Console.WriteLine();
            
            return cliente;
        }
    }
}